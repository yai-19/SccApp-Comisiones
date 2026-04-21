using SccApp.Domain.Interfaces;

namespace SccApp.Domain.Services;

public class CommissionCalculator : ICommissionCalculator
{
    public double Calculate(double amount, double percentage) => amount * percentage;
}