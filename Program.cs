namespace MultiplesOfNumbers;

class Program
{
    static void Main(string[] args)
    {
        int numberFirst = 10;
        int numberLast = 25;

        for (int i = numberFirst; i <= numberLast; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        numberFirst = 50;
        numberLast = 150;

        for (int i = numberFirst; i <= numberLast; i++)
        {
            Console.WriteLine(i);
        }
    }
}
