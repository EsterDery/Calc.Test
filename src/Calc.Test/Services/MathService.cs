using Calc.Test.Models;
using System;

namespace Calc.Test.Services
{
    public class MathService : IMathService
    {
        public MathService()
        {

        }
        /// <inheritdoc/>
        public decimal? Calc(string operation, MathCalcBody dto)
        {
            switch (operation)
            {
                case "plus":
                    return dto.Num1 + dto.Num2;
                case "minus":
                    return dto.Num1 - dto.Num2;
                case "multiplication":
                    return dto.Num1 * dto.Num2;
                case "division":
                    return dto.Num2 != 0 ? dto.Num1 / dto.Num2 : throw new DivideByZeroException();
                default:
                    throw new ArgumentException("operation not valid");
            }
        }
    }
}
