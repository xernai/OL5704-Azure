using System;

namespace StaticClassAndConstructors
{
    class MathHelper
    {
        //public MathHelper()
        //{

        //}

        // Singleton
        private MathHelper()
        {

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sqrt(int a)
        {
            // TODO aplicar logica para obtener la raiz cuadrada
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var area = Math.Sqrt(16);

            // Math math = new Math();
            // MathHelper mathHelper = new MathHelper();
            var area1 = MathHelper.Add(1, 2);
        }
    }
}
