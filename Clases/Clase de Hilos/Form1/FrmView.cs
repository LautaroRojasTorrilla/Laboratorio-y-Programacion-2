namespace Form1
{
    public partial class FrmView : Form
    {
        CancellationTokenSource cancellationTokenSource;
        Task tarea;

        public delegate void Callback(DateTime hora, string saludo);

        public FrmView()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //generamos la instancia y hacemos el token.
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            this.tarea = Task.Run(() => this.IniciarReloj(this.cancellationTokenSource), token);
        }

        //no puedo modificar mi formulario desde un hilo secundario
        private void ActualizarHora(DateTime hora, string saludo)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarHora);
                //se le puede pasar un array de obj como 2do parametro al BeginINvoke
                object[] args = { hora, saludo };

                //vamos a invocar al hilo ppal para decirle que actualice el lbl
                //hace llamada recursiva e indica que estoy en el hilo ppal
                //entonces ya no necesita invocacion y actualiza el lbl
                this.BeginInvoke(callback, args);

                ////resumoido
                //this.BeginInvoke(() => this.ActualizarHora(hora, saludo));
            }
            else
            {
                this.lblHora.Text = $"{hora}";
                this.txtIngreso.Text = saludo;
            }
        }


        private void IniciarReloj(CancellationTokenSource cancellationTokenSource)
        {
            //all ppio está bloqueado el hilo ppal,
            //entonces nisiquiera la pc tiene la capacidad de refrescar ese form

            int numero = 0;

            do
            {
                this.ActualizarHora(DateTime.Now, $"Hola Mundo {numero}");
                Thread.Sleep(1000);
                numero++;
            } while (true && !cancellationTokenSource.IsCancellationRequested);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}