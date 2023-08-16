namespace Clase_de_Hilos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task tarea = Task.Run(MiMetodo);

            Console.WriteLine($"En el MAIN {Thread.CurrentThread.ManagedThreadId}");
            Task tarea2 = Task.Run(MiMetodo);
            Task tarea3 = Task.Run(MiMetodo);

            Console.WriteLine("La taresa esta iniciada e imprimo en paralelo 1");
            Console.WriteLine("La taresa esta iniciada e imprimo en paralelo 2");
            Console.WriteLine("La taresa esta iniciada e imprimo en paralelo 3");
            Console.WriteLine("La taresa esta iniciada e imprimo en paralelo 4");

            //le inidco que espere que termine el hilo secundario antes de matar todo.
            tarea.Wait();

            Console.WriteLine("Termino mis tareas");

            //ConsoleKey teclaPresionada;
            //CancellationTokenSource cancellation = new CancellationTokenSource();
            //CancellationToken token = cancellation.Token; 


            //////genero la instancia, no lo ejectuo nunca
            //////recibe un delegado de tipo action
            //////le paso el método par aejecutar en hilo secundario
            ////Task task = new Task(ImprimirHora);

            //////para ejecutarlo
            ////task.Start();

            ////de manera resumida
            ////Dentro va el action. Esto devuelve una instancia de task y lo pone a correr.
            ////le paso el token para que esa tarea tenga la opción de ser canc a traves de él
            //Task task = Task.Run(() => ImprimirHora(cancellation), token);


            //do
            //{
            //    teclaPresionada = Console.ReadKey().Key;
            //    Console.WriteLine($"Presiono {teclaPresionada}");
            //    if(teclaPresionada == ConsoleKey.Spacebar)
            //    {
            //        cancellation.Cancel();
            //    }

            //} while (teclaPresionada != ConsoleKey.Escape);


            //Console.WriteLine("Presiono escape, salí del primer dowhile");

            ////Console.ReadKey();
        }

        //static void ImprimirHora(CancellationTokenSource cancellation)
        //{
        //    do
        //    {
        //        Console.WriteLine($"{DateTime.Now}");
        //        //suspende el hilo donde se ejecuta el tiempo indicado en milisegs.
        //        Thread.Sleep( 1000 );
        //        Console.Clear();
        //    }while (true && !cancellation.IsCancellationRequested);
        //    //va a ir corriende mientras sea true y el cancellation no requiera cancelación
        //}

        static void MiMetodo()
        {
            Console.WriteLine($"El id del task en mi metodo {Task.CurrentId}");
            Console.WriteLine($"En mi metodo {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteración numero {i}");
                Thread.Sleep(1000);
            }
        }
    }

}