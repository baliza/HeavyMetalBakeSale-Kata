namespace MetalBakeLibrary
{
    public interface IRepaymentCalculator
    {
        double getRepayment(double totalMoney, double userMoney);
    }
}