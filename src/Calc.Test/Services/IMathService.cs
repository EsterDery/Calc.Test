using Calc.Test.Models;

namespace Calc.Test.Services
{
    public interface IMathService
    {
        decimal? Calc(string operation, MathCalcBody dto);
    }
}
