namespace MetalBake.Services
{
    public interface IRepaymentCalculator
    {
        double getRepayment(double totalMoney, double userMoney);
    }
}