using System;

namespace multiplo
{
    public class Util
    {
        public static string EsMultiplo(int a, int b)
        {
            if(a % b ==0)
            {
                return string.Format("El número a: {0}, es múltiplo del número b: {1}", a, b);
            }
            else
            {
                return string.Format("El número a: {0}, no es múltiplo del número b: {1}", a, b);
            }
        }
    }
}
