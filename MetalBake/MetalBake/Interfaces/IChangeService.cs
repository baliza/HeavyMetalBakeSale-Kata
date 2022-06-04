namespace MetalBake.Interfaces
{
    public interface IChangeService
    {
        decimal GetChange(decimal totalPrice, decimal amountForPay);
    }
}