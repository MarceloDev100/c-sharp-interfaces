using Project2.Entities;

namespace Project2.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessInstallments(Contract contract, int months)
        {
            double totalValue = contract.TotalValue;
            double installmentValue = totalValue / months;
            DateTime date = contract.Date;

            for(int month = 1; month <= months; month++)
            {
                date = date.AddMonths(1);

                double monthlyInterest = _paymentService.CalculateMonthlyInterest(installmentValue, month);
                double amount = _paymentService.CalculateFee(monthlyInterest);

                contract.AddInstallment(new Installment(date, amount));
            }
        }
    }
}
