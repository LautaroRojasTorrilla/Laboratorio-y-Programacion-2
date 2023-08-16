using Entidades.Enumerados;


namespace Entidades.MetodosDeExtension
{
    //saber que la clase y le metodo tienen que ser STATIC y poner el this
    //LUEGO SE TRATARAN COMO METODOS DE INSTANCIA
    public static class IngredientesExtension
    {
        //cuando genere una instancia d elista de ingredientes,
        //la lista dentro va a tener el método CalcularCosto
        //voy a estar extendiendo la clase list para los ingredientes.
        public static double CalcularCostoIngredientes(this List<EIngrediente> ingredientes, int costoInicial)
        {
            foreach (EIngrediente ingrediente in ingredientes)
            {
                costoInicial += costoInicial * (int)ingrediente / 100;
            }

            //ingredientes.ForEach(ingrediente => costoInicial += (costoInicial * (int)ingrediente / 100));
            return costoInicial;

        }

        public static List<EIngrediente> IngredientesAleatorios(this Random random)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>()
            {
                EIngrediente.QUESO,
                EIngrediente.PANCETA,
                EIngrediente.ADHERESO,
                EIngrediente.HUEVO,
                EIngrediente.JAMON,
            };

            int cantidad = random.Next(1, ingredientes.Count+1);
            return ingredientes.Take(cantidad).ToList();
        }
    }
}
