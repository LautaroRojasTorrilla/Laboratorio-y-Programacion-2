using Entidades;
using System.Security.Cryptography;

namespace Delegados_y_Expresiones_Lambda
{
    internal class Program
    {
        public delegate void MiDelegado();
        public delegate string MiDelegado2();
        public delegate string MiDelegado3(string value1, string value2);

        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>() 
            {new Persona ("Pepe", 50), new Persona ("Raul", 44),
            new Persona ("Lucas", 52)};

            ////no recibe params y no tiene retorno.
            //Action action = () => { Console.WriteLine("Hola Mundo desde mi action");  };
            //action.Invoke();

            ////implícitamente el retorno es loq ue está a la derecha del =>
            //Comparison<Persona> comparison = (p1, p2) => p1.Edad - p2.Edad;

            //asi lanza una excepcion lista.Sort();
            //le paso una funcion lambda que va a estar ordenando por persona
            //es lo mismo que pasarle la func criterio.
            lista.Sort((p1, p2) => p1.Edad - p2.Edad);
            
            //recibe un predicate, una fn que recibe un único elemento y tiene que retonar un bool
            Persona p = lista.Find(p => p.Edad == 50);

            //es la manera más acotada. Por detras hace un foreach y en cada llamada le pasa el delegao y lo compara
            //con la funcion criterio que tenga dentro
            bool result = lista.Exists(p => p.Nombre == "Lucas");

            Console.WriteLine(p.ToString());
            Console.WriteLine(result);

            //también le puedo pasar directamente la funcion criterio
            //lista.Sort(FuncionCriterio);

            foreach (Persona persona in lista)
            {
                Console.WriteLine(persona.ToString());
            }

            //MiDelegado3 miDelegado = MiMetodoParticular;

            ////un delegado que retrona un 1 st y recibe 2 st como parametro.
            //Func<string, string, string> miDelegadoParticular = MiMetodoParticular;

            //string resultado = miDelegado("Pepe", "Diaz");

            //Console.WriteLine (resultado);


            //Action delegado2 = HacerAlgo;

            //Recibe argumentos entre <>, encapsula métodos que no reciben parametros
            //pero retonan un valor de tipo especificado.
            //Func<int, string> delegadoFunc = Saludar;

            //Recibe un valor y tiene que retornar un booleano. Se utiliza para comparaciones.
            //No tiene sobrecargas.
            //Predicate<string> delegado3 = Saludar2;

            //Recibe 2 tipos genéricos y tiene que retornar un entero
            //Se usa para el método sort.
            //Comparison<Persona> delegado4 = FuncionCriterio;

            ////Hace referencia a métodos que retornen un int y reciban un string.
            ////Es indistinto cuál se use.
            //MiDelegado miDelegado = new MiDelegado(MetodoParaMiDelegado);
            //MiDelegado miDelegado2 = MetodoParaMiDelegado;
            ////los delegados pueden encapsular VARIOS métodos. Le puedo ir agregando ref a metodos
            //miDelegado2 += MetodoParaMiDelegado2;

            //DELEGADO MULTIDIFUSION
            //Se ejecturan todos los métodos encapsulados. Y hasta se pueden repetir.
            //Es para agrupar todos los métodos que voy a ejecutar siempre en secuencia.
            //MiDelegado miDelegado = new MiDelegado(MetodoParaMiDelegado);
            //miDelegado += MetodoParaMiDelegado2;
            //miDelegado += MetodoParaMiDelegado3;
            //miDelegado();

            //Console.ReadKey();

            //MiDelegado2 miNuevoDelegado = MetodoParaMiNuevoDelegado;
            //miNuevoDelegado += MetodoParaMiNuevoDelegado2;

            //foreach (MiDelegado2 d in miNuevoDelegado.GetInvocationList())
            //{
            //    //d() viene del delegado que retorna un string
            //    //para hacer referencia que se está invocando al método
            //    string algo = d.Invoke();
            //    Console.WriteLine(algo);
            //}

            /*
             * Action - van a ser delegados que no retornan valores.
                        Action delegado = HacerAlgo;
                        Action<int> delegado2 = HacerAlgo; 
             * Func - van a ser delegados que retornan un tipo genérico y pueden recibir parámetros
             * Predicate - van a ser delegados que recibe un parámetro y retorna bool
             * Comparison - van a ser delegados que reciben 2 genéricos y retorna INT
            */
        }

        static void HacerAlgo()
        {
            Console.WriteLine("Hola Mundo!");
        }

        static string Saludar(int numero)
        {
            return "Hola Mundo";
        }

        static bool Saludar2(string value)
        {
            return value == "Hola Mundo";
        }

        static int FuncionCriterio(Persona personaA, Persona personaB) 
        {
            return personaA.Edad - personaB.Edad;
        }

        static void MetodoParaMiDelegado()
        {
            Console.WriteLine("Hola Mundo Dsde mi MetodoParaMiDelegado");
        }

        static void MetodoParaMiDelegado2()
        {
            Console.WriteLine("Hola Mundo Dsde mi MetodoParaMiDelegado 2 lalalalla");
        }

        static void MetodoParaMiDelegado3()
        {
            Console.WriteLine("Hola Mundo Dsde mi MetodoParaMiDelegado 3 muejejeje");
        }

        static string MetodoParaMiNuevoDelegado()
        {
            return "Hola mundo desde mi MetodoParaMiNuevoDelegado";
        }

        static string MetodoParaMiNuevoDelegado2()
        {
            return "Hola mundo desde mi MetodoParaMiNuevoDelegado2222222222";
        }

        static string MiMetodoParticular(string value, string value2)
        {
            return $"Hola como estas {value}, {value2}";
        }
    }
}