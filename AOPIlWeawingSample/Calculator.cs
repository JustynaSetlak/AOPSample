using AOPIlWeawingSample.Attributes;

namespace AOPIlWeawingSample
{
    public class Calculator
    {
        [MeasureTime]
        public int AddNumbers(int firstNmber, int secondNumber)
        {
            var sum = firstNmber + secondNumber; 
            return sum;
        }
    }
}