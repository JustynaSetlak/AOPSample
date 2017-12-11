namespace AOPSample
{
    public class Calculator
    {
        public virtual int AddNumbers(int firstNmber, int secondNumber)
        {
            var sum = firstNmber + secondNumber;
            return sum;
        }
    }
}