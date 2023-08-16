namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> colaPos = new Queue<int>();
            Stack<int> pilaPos = new Stack<int>();
            Queue<int> colaNeg = new Queue<int>();
            Stack<int> pilaNeg = new Stack<int>();

            Random r = new Random();

            for (int i = 0; i < 20; i++) 
            { 
                lista.Add(r.Next(-100,100));
            }

            Console.WriteLine("Lista original");
            
            foreach (int i in lista)
            {
                //porque i ya es el numero de la lista.
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Ordenada decreciente");
            lista.Sort(Program.OrdenDescendente);
            foreach (int i in lista)
            {
                //porque i ya es el numero de la lista.
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista de numeros positivos");
            foreach(int i in lista)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    //agrego positivo a la cola de positivos
                    colaPos.Enqueue(i);
                }
                else if (i != 0)//valido que no seal cero
                {
                    //agrego negativos a la lista de negativos
                    pilaNeg.Push(i);
                }
            }

            Console.WriteLine("Lista de Negativos");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    //agrego positivo a la pila de positivos
                    pilaPos.Push(lista[i]);
                }
                else if (i != 0)//valido que no seal cero
                {
                    Console.WriteLine(lista[i]);
                    //agrego negativos a la lista de negativos
                    colaNeg.Enqueue(lista[i]);
                }
            }

            Console.WriteLine("Cola de numeros positivos");
            foreach (int i in colaPos)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" Pila Positivos");
            foreach (int i in pilaPos)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" Cola Negativos");
            foreach (int i in colaNeg)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" Pila Negativos");
            foreach (int i in pilaNeg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
}