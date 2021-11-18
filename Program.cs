using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInicio;
            int nFinal;

            Console.WriteLine("100 primeiros números naturais não nulos.");

            nInicio = 1;

            nFinal = 100;

            while(nInicio <= nFinal)
            {
                Console.Write($" {nInicio} ");
                nInicio = nInicio + 1;
            }
        }
    }
}
