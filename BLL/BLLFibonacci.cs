using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLLFibonacci
    {
        private static int nSequencia = 0;

        public static string FibonacciInterativa(long nElemento)
        {
            DateTime dtTempoInicial = DateTime.Now;
                      
            long x = 1, y = 0, nResultado = 0;

            for (nSequencia = 0; nSequencia < nElemento; nSequencia++)
            {
                nSequencia++;
                nResultado = x + y;
                y = x;
                x = nResultado;
            }

            TimeSpan oDif = DateTime.Now - dtTempoInicial;

            return string.Format(" Resultado: {0}, Elemento: {1}, Sequencia: {2}, Duração: {3} ",
                nResultado, nElemento, nSequencia, oDif.TotalMilliseconds);
        }

        public static string FibonacciRecursiva(long nElemento)
        {
            long nResultado = 0;

            nSequencia = 0;

            DateTime dtTempoInicial = DateTime.Now;

            nResultado = Fibonacci_Recursiva(nElemento);

            TimeSpan oDif = DateTime.Now - dtTempoInicial;

            return string.Format(" Resultado: {0}, Elemento: {1}, Sequencia: {2}, Duração: {3} ",
                nResultado, nElemento, nSequencia, oDif.TotalMilliseconds);
        }

        private static long Fibonacci_Recursiva(long nElemento)
        {
            nSequencia++;

            if (nElemento <= 1)
            {
                return 1;
            }

            return Fibonacci_Recursiva(nElemento - 1) + Fibonacci_Recursiva(nElemento - 2);
        }
    }
}
