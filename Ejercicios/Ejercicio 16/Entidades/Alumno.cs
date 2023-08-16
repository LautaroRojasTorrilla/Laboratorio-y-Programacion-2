namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4) 
            {
                Random rd = new Random();

                this.notaFinal = rd.Next((int)this.nota1, (int)this.nota2);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            if(this.notaFinal != -1)
            {
                return $"El alumno {this.nombre} {this.apellido} tiene como nota final: {this.notaFinal}";
            }
            return $"El alumno {this.nombre} {this.apellido} está desaprobado";
        }

    }//fin clase

}//fin namespace