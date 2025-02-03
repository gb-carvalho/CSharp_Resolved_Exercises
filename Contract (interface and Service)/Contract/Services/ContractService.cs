using System;
using ContractProgram.Entities;

namespace ContractProgram.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void CalculateInstallment(Contract contract, int months) 
        { 
            for (int i = 1; i <= months; i++)
            {
                DateTime installment_date = contract.Date.AddMonths(i);
                double amount = contract.TotalValue / months;
                amount += _onlinePaymentService.Interest(amount, i);
                amount += _onlinePaymentService.PaymentFee(amount);
                Installment installment = new Installment(installment_date, amount);
                contract.Installments.Add(installment);
            }
        }
    }
}
