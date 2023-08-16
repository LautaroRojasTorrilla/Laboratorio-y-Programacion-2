namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////No lo permite por el constructor es privado
            ////Persona P = new Persona();

            ////las conversiones nos permiten hacer compatibles tipos que antes no lo eran.
            //Persona p = 1111;
            ////Esto lo puedo hacer por la conversión implicita.
            //Persona p2 = Persona.GetPersona(p);


            ////así le puedo asignar al dni, desde un objeto persona.
            ////Construyo desde el main, con un constructor privado.
            //int dni = p;



            //Console.WriteLine(p.GetDNI());

            Persona p = Persona.GetPersona(111);
            Persona p4 = Persona.GetPersona(222);
            Persona p5 = 111;

            //a través de este patrón de diseño siempre devuelve la misma instancia
            //no tiene la posilibilidad de crear otro objeto
            Console.WriteLine(p == p4);

            //estos 2 dan falso porque son instancias distintas.
            Console.WriteLine(p == p5);
            Console.WriteLine(p5 == p4);
        }
    }
}