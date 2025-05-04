using Domain;
namespace TestCalculator
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("Test Insert 1", 1, 2, 3)]
        [InlineData("Test Insert 2", 4, 9, 13)]
        [InlineData("Test Insert 3", 3, 4, 7)]
        public void Test1(string testcasename, int left, int right, int expect)
        {
            var calculator = new Calculator();
            if (calculator.Sum(left, right) != expect)
            {
                throw new Exception();
            }
        }

    }
}