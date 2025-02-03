using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    internal class Aluno
    {
        public string? Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {   
            if (NotaFinal() >= 60.00) return true;
            else return false;
        }

        public double NotaRestante()
        {
            if (!Aprovado()) return 60.00 - NotaFinal();
            else return 0.00;
        }
    }
}
