namespace Project2.Services
{
    interface IPaymentService
    {
        double CalculateMonthlyInterest(double amount, int month);
        double CalculateFee(double amount);
    }
}
