using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractProgram.Entities
{
    public class Installment
    {
        public DateTime DueTime { get; set; }
        public double Amount { get; set; }

        public Installment (DateTime dueTime, double amount)
        {
            DueTime = dueTime;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueTime.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2");
        }
    }
}
