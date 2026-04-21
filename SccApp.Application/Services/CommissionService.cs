using SccApp.Domain.Base;
using SccApp.Domain.Interfaces;


namespace SccApp.Application.Services;
public class CommissionService
{
    private readonly ICommissionCalculator _calculator;

    public CommissionService(ICommissionCalculator calculator)
    {
        _calculator = calculator;
    }

    public Result<double> CalculateCommission(double sales, double discounts, string country)
    {
        
        if (sales < 0 || discounts < 0)
            return Result<double>.Failure("Los montos no pueden ser negativos.");

        var baseAmount = sales - discounts;
        if (baseAmount < 0)
            return Result<double>.Failure("Los descuentos no pueden superar las ventas.");

        var percentage = GetPercentageByCountry(country);
        var result = _calculator.Calculate(baseAmount, percentage);

        return Result<double>.Success(result);
    }

    private double GetPercentageByCountry(string country) => country switch
    {
        "India" => 0.10,
        "US" => 0.15,
        "UK" => 0.12,
        _ => 0
    };
}
