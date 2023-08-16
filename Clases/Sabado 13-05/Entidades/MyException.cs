namespace Entidades
{
    public class MyException : Exception
    {
        Object error;

        public MyException(string mensaje, object objError) : base(mensaje)
        {
            this.error = objError;
        }

        public Object Error
        {
            get { return error; }
        }
    }
}