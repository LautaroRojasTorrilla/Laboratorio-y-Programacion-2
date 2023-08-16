using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using Entidades.DataBase;


namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraAtencion(double demora);
    public delegate void DelegadoNuevoIngreso(IComestible comida);

    public class Cocinero<T> where T : IComestible, new()
    {
        private int cantPedidosFinalizados;
        private string nombre;
        private double demoraPreparacionTotal;
        private CancellationTokenSource cancellation;
        private T menu;
        private Task tarea;

        private Mozo<T> mozo;
        private T pedidoEnPreparacion;

        public event DelegadoDemoraAtencion OnDemora;
        public event DelegadoNuevoIngreso OnIngreso;





        public Cocinero(string nombre)
        {
            this.nombre = nombre;
        }


        public bool HabilitarCocina
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running
                    || this.tarea.Status == TaskStatus.WaitingToRun
                    || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.HabilitarCocina)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarIngreso();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        public double TiempoMedioDePreparacion { get => this.cantPedidosFinalizados == 0 ? 0 : this.demoraPreparacionTotal / this.cantPedidosFinalizados; }
        public string Nombre { get => nombre; }

        private void IniciarIngreso()
        {
            CancellationToken token = this.cancellation.Token;
            this.tarea = Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoIngreso();
                    this.EsperarProximoIngreso();
                    this.cantPedidosFinalizados++;

                    //guardar el tk en la base de datos. Que puede largar una excepcion.
                    //Esto podría estar en el método finalizar preparación.
                    try
                    {
                        DataBaseManager.GuardarTicket(this.nombre, this.menu);
                    }
                    catch (DataBaseManagerException ex)
                    {
                        FileManager.Guardar(ex.Message, "logs.txt", true);
                    }
                    
                }
            }, token);
        }

        private void NotificarNuevoIngreso()
        {
            if (this.OnIngreso is not null)
            {
                this.menu = new T();
                this.menu.IniciarPreparacion();
                //estoy notificando el menu
                this.OnIngreso.Invoke(this.menu);
            }
        }
        private void EsperarProximoIngreso()
        {
            //es el tiempo de espera transcurrido
            int tiempoEspera = 0;

            while(this.OnDemora is not null && !this.menu.Estado && !this.cancellation.IsCancellationRequested)
            {
                tiempoEspera++;
                this.OnDemora.Invoke(tiempoEspera);
                Thread.Sleep(1000);
            }
            this.demoraPreparacionTotal += tiempoEspera;
        }
    }
}
