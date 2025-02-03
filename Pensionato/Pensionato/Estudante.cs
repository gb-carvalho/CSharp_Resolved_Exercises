using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Estudante
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int Quarto { get; set; }

        public Estudante(string? nome, string? email, int quarto) { 
            this.Nome = nome;
            this.Email = email;
            this.Quarto = quarto;
        }

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }

    }
}
