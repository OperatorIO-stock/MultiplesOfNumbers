namespace MultiplesOfNumbers;

class Program
{
    static void Main(string[] args)
    {
        int numberIntervalFirst = 10;
        int numberIntervalLast = 25;
        int numberLowerLimit = 50;
        int numberUpperLimit = 150;
        int numbersValid = 0;

        Random random = new Random();
        int numberN = random.Next(numberIntervalFirst, numberIntervalLast);

        for (int i = 0; i <= numberUpperLimit; i += numberN)
        {
            if (i >= numberLowerLimit)
                numbersValid++;
        }
        
        Console.WriteLine($"The number of multiples '{numberN}': {numbersValid}");
    }
}
