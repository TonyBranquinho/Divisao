using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double  divisao, numerador, denominador;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            numerador = 0;
            denominador = 0;
            divisao = 0;

            for (i = 0; i < n; i++) {
                Console.Write("Entre com o numerador: ");
                numerador = int.Parse(Console.ReadLine());
                Console.Write("Entre com o denominador: ");
                denominador = int.Parse(Console.ReadLine());

                divisao = numerador / denominador;

                if (numerador < 0) {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else {
                    Console.WriteLine("DIVISAO = " + divisao.ToString("F2", CI));
                }
            }
        }
    }
}
