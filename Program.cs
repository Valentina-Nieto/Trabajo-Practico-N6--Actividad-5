using System;

namespace actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicitar que se ingrese 2 números e indicar mayor, menor o igual.*/
            
            string entrada = "";
            float nro1 = 0f;
            float nro2 = 0f;

            Console.Clear();

            Console.WriteLine("Ingrese un número");
            entrada = Console.ReadLine();
            nro1 = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese otro número");
            entrada = Console.ReadLine();
            nro2 = Convert.ToSingle(entrada);

            if (nro1 > nro2)
                Console.WriteLine("El número {0} es el Mayor y el número {1} es el Menor", nro1, nro2);

            else if (nro1 < nro2)
                Console.WriteLine("El número {0} es Menor y el número {1} es el Mayor", nro1, nro2);

            if (nro1 == nro2)
                Console.WriteLine("Los números ingresados son iguales");

            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
