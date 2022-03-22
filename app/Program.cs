using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese el primer número");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(multiplo.Util.EsMultiplo(a, b));
            Console.ReadKey();
        }
    }
}
