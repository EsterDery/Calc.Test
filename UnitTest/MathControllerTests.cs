using Calc.Test.Models;
using Calc.Test.Services;

namespace UnitTest
{
    public class MathControllerTests
    {
        private  IMathService _mathService;

        
        [SetUp]
        public void SetUp()
        {
            _mathService = new MathService();
        }
        // Test Case#1: Plus  : Verification
        [Test]
        public void Plus()
        {
            var result = _mathService.Calc("plus", new MathCalcBody(6, 10));
            Assert.AreEqual(result , 16);
        }

        // Test Case#2: minus  : Verification
        [Test]
        public void Minus()
        {
            var result = _mathService.Calc("minus", new MathCalcBody(85, 10));
            Assert.AreEqual(result, 75);
        }

        // Test Case#3: multiplication  : Verification
        [Test]
        public void Multiplication()
        {
            var result = _mathService.Calc("multiplication", new MathCalcBody(6, 10));
            Assert.AreEqual(result, 60);
        }

        // Test Case#4: Division Num 2 is 0 : Verification
        [Test]
        public void DivisionByZero()
        {
            try
            {
                var result = _mathService.Calc("division", new MathCalcBody(6, 0));
                Assert.Fail("not falid when division by zero");
            }
            catch (Exception e) {
                Assert.IsTrue(e.Message.ToString().Contains("Attempted to divide by zero"),e.Message);
            }
        }

        // Test Case#5: Division  : Verification
        [Test]
        public void Division()
        {
            var result = _mathService.Calc("division", new MathCalcBody(10, 2));
            Assert.AreEqual(result, 5);
        }


        // Test Case#5: Division  : Verification
        [Test]
        public void InvalidOperation()
        {
            try
            {
                var result = _mathService.Calc("invalid", new MathCalcBody(6, 0));
                Assert.Fail("not falid when invalid opration");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.ToString().Contains("operation not valid"), e.Message);
            }
        }
    }
}