namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor(ConsoleColor color) 
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        private void SetTinta(short tinta) 
        { 
            if(tinta > 0)
            {
                this.Cargar(this.tinta);
            }
            else if(tinta < 0)
            {
                this.GastarTinta(tinta);
            }
        }

        private void GastarTinta(short tinta)
        {
            int tintaAux = this.tinta - tinta;
            if(tintaAux <= 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta = tintaAux;
            }
        }

        private void Cargar(short tinta)
        {
            int tintaAux = this.tinta + tinta;

            if(tintaAux >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else
            {
                this.tinta = (short) tintaAux;
            }
        }

        public void Recargar()
        {
            this.Cargar(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = "";

            if(this.tinta == 0)
            {
                dibujo = "No es posible Pintar";
                return false;
            }

            //ver como terminar esto.
            //dentro del valor le pasaria tinta-gasto o algo asi
            //"".PadRight
            //for (int i = 0; i < gasto; i++)
            //{
            //    dibujo = cadenaAux + "*";
            //}
            //return true;

            while(gasto > 0 && this.tinta > 0) 
            {
                dibujo = cadenaAux + "*";
                this.tinta--;
                gasto--;
            }
            dibujo = cadenaAux;
            return true;
        }
    }
}