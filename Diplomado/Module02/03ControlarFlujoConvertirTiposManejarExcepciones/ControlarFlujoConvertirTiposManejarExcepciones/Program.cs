using System;

namespace ControlarFlujoConvertirTiposManejarExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string input = String.Empty;

            Console.WriteLine("Teclea el valor y al final da Enter.");

            input = Console.ReadLine();
            //age = Convert.ToInt32(input);

            // var value = Console.ReadLine();

            // Error next sentences
            // age = (int)value;
            // age = (int)"45"

            // Uso de casting para convertir un tipo de dato a otro siendo ambos del tipo de dato por valor (value)
            /*
            age = (int)edad;

            age = 300;
            byte edad1 = (byte)age;

            Console.WriteLine($"Valor de edad: {edad1}");
            */

            /*
            try
            {
                age = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return;
            }
            */

            try
            {
                age = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return;
            }
            finally
            {
                Console.WriteLine("Fin del proceso");
            }

            
            /*
            if (age > 17 && age < 65)
            {
                Console.WriteLine("Eres candidato a una tarjeta de crédito");
            }

            if (age < 18)
            {
                Console.WriteLine("No Eres candidato a una tarjeta de crédito");
            }

            if (age >= 65)
            {
                Console.WriteLine("Pensión Adultos Mayores");
                PagosBimestrales();
            }
            */
            

            /*
            if (age > 17 && age < 65)
            {
                Console.WriteLine("Eres candidato a una tarjeta de crédito");
            }
            else
            {
                if (age < 18)
                {
                    Console.WriteLine("No Eres candidato a una tarjeta de crédito");
                }
                else
                {
                    if (age >= 65)
                    {
                        Console.WriteLine("Pensión Adultos Mayores");
                        PagosBimestrales();
                    }
                }
            }
            */

         
            if (age > 17 && age < 65)
            {
                Console.WriteLine("Eres candidato a una tarjeta de crédito");
            }
            else if (age < 18)
            {
                Console.WriteLine("No Eres candidato a una tarjeta de crédito");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Pensión Adultos Mayores");
                PagosBimestrales();
            }
            
        }
        
        /*
        private static void PagosBimestrales()
        {
            for (int i = 0; i < 6; i++) 
            { 
                Console.WriteLine($"Bimestre: {i + 1} => 3000");
            }
        }
        */
        

        
        private static void PagosBimestrales()
        {
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine($"Bimestre: {i + 1} => 3000");
                i++;
            }
        }
        

        /*
        private static void PagosBimestrales()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Bimestre: {i + 1} => 3000");
                i++;  // i = i + 1;
            }
            while (i < 6);
        }

        */
    }
}
