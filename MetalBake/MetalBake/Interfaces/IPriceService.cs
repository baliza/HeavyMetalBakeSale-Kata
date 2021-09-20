namespace MetalBake
{
    public interface IPriceService
    {
        decimal TotalToPay(string[] itemId);
    }
}