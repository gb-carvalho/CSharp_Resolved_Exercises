using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    internal class ConversorDeMoedas
    {
        internal static double ConverterDolarReal(double dolar, double cotacao) {
            return dolar * cotacao * (1.0 + 6.0/100);  //6% de IOF
        }
    }
}
