using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(this.vertice3.GetX(), this.vertice1.GetY());
            this.vertice4 = new Punto(this.vertice1.GetX(), this.vertice3.GetY());
        }

        private int Base()
        {
            return Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
        }

        private int Altura()
        {
            return Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
        }

        public float Perimetro()
        {
            if(this.area == 0f)
            {
                this.area = (Base() + Altura()) * 2;
            }
            return this.area;
        }

        public float Area()
        {
            if (this.perimetro == 0f)
            {
                this.perimetro = Base() * Altura();
            }
            return this.perimetro;
        }

        public void Mostrar()
        {
            Console.WriteLine($"El rectagulo de vertices {this.vertice1.Mostrar()}, {this.vertice2.Mostrar()}, {this.vertice3.Mostrar()} y {this.vertice4.Mostrar()} y cuya area es {this.Area()} y perimetro es {this.Perimetro()}");
        }
    }
}
