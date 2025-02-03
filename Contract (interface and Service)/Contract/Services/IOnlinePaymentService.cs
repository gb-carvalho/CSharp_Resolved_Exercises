using System;

namespace ContractProgram.Services
{
    interface IOnlinePaymentService
    {
        double Interest(double amount, int days);
        double PaymentFee(double amount);
    }
}
