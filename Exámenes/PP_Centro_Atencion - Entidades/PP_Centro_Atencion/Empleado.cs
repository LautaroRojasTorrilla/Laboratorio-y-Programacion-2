namespace PP_Centro_Atencion
{
    public abstract class Empleado
    {
        private TimeSpan horaEgreso;
        private TimeSpan horaIngreso;
        private string legajo;
        private string nombre;

        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public TimeSpan HoraEgreso { get => horaEgreso; set => ValidaHoraEgreso(this.horaEgreso); }
        public TimeSpan HoraIngreso { get => horaIngreso; }
        public string Legajo { get => legajo; }
        public string Nombre { get => nombre; }

        public abstract string EmitirFactura();

        private TimeSpan ValidaHoraEgreso(TimeSpan horaEgreso)
        {
            if (horaEgreso > this.horaIngreso)
            {
                return horaEgreso;
            }
            return DateTime.Now.TimeOfDay;
        }

        protected virtual double Facturar()
        {
            double totalHoras = (HoraEgreso - HoraIngreso).TotalHours;
            return totalHoras;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            return emp1.legajo == emp2.legajo;
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }
    }
}