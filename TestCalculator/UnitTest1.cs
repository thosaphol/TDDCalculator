using Domain;
namespace TestCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            if (calculator.Sum(2,2) != 4)
            {
                throw new Exception();
            }
        }

    }
}