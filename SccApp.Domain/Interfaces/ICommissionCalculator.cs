
namespace SccApp.Domain.Interfaces
{
    public interface ICommissionCalculator
    {
        double Calculate(double amount, double percentage);
    }
}
