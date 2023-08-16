using Entidades;
using Entidades.Exceptions;
using Entidades.Files;
using System.Runtime.InteropServices;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestUnitariosAhorcado
    {
        /*
         * 
         * 22.	Darle un nombre claro al proyecto, sus clases y sus métodos
           23.	Agregar 2 test unitarios:
           a.	Forzar, mediante el código la ejecución de FileManagerException, validar que suceda de forma correcta.
           b.	Al instanciar un nuevo juego, la cantidad de aciertos debe ser igual a 0 (cero).

           Al finalizar, colocar la carpeta de la carpeta de la Solución completa en un archivo ZIP que deberá tener como nombre Apellido.Nombre.division.zip y compartir este por Slack sólo con el docente titular de la cursada.

         * */
        [TestMethod]
        [DataRow("imagen.jpeg")]
        [DataRow("imagen.asdad")]
        public void Excepcione_CuandoHayErrorEnArchivo_DeberiaArrojarExcepcion(string value)
        {
            //arrange
            //string archivoTest = "imagen.jpeg";
            Ahorcado<Pais> ahorcado = new Ahorcado<Pais>();

            ////act
            //FileManager.Guardar<Ahorcado<Pais>>(ahorcado, archivoTest);

            ////them
            //Assert.ThrowsException();

            // act y assert
            Assert.ThrowsException<FileManagerException>( () => FileManager.Guardar<Ahorcado<Pais>>(ahorcado, value));
        }
        [TestMethod]
        public void Ahorcado_CuandoEsInstanciado_AciertosDeberiaSerCero()
        {
            //arrange
            Ahorcado<Pais> ahorcado = new Ahorcado<Pais>();

            //act
            int aciertos = ahorcado.CantidadDeAciertos;

            //assert
            Assert.AreEqual(0, aciertos);
        }
    }
} 