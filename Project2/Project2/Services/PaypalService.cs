namespace Project2.Services
{
    class PaypalService : IPaymentService
    {
        public double CalculateFee(double amount)
        {
            return amount + amount * 0.02;
        }

        public double CalculateMonthlyInterest(double amount, int month)
        {
            return amount + amount * month / 100;
        }
    }
}
