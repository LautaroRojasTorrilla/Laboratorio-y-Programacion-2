using System.Text;

namespace Entidades
{
    public enum EVehiculos {Automovil, Moto};
    public abstract class Vehiculo
    {
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private string patente;



        public string Patente 
        { 
            get => patente;

            set
            {
                if(this.ValidarPatente(value)) 
                { 
                    this.patente = value;
                }
            }
        }

        public abstract string Descripcion { get; }
        public abstract double CostoEstadia { get; }
        public DateTime HoraIngreso { get => horaIngreso;}
        public DateTime HoraEgreso 
        { 
            get => horaEgreso; 
            
            set
            {
                if (value >= this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        protected Vehiculo(DateTime horaIngreso, string patente)
        {
            this.horaIngreso = horaIngreso;
            this.Patente = patente;
        }

        private bool ValidarPatente(string patente)
        {
            if( !string.IsNullOrEmpty(patente) && patente.Length > 5 && patente.Length < 8 )
            {
                return true;
            }
            return false;
        }

        protected virtual double CargoDeEstacionamiento()
        {
            //if (this.HoraEgreso > this.HoraIngreso)
            //{
            //    return (this.HoraEgreso - this.HoraIngreso).TotalHours;
            //}
            //return 0;
            return (this.HoraEgreso - this.HoraIngreso).TotalHours;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"La patente es: {this.Patente}");
            sb.AppendLine($"La hora de ingreso es: {this.HoraIngreso}");
            sb.AppendLine($"La hora de egreso es: {this.HoraEgreso}");

            return sb.ToString();
        }

        public static bool operator==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator!=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }

    }
}