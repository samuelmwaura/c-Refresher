namespace fundamentals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is for the Lord!");
        int[] numbers = new int[3] { 89, 276,47,}; // can get rid of int[] and use var and compile knows
        Console.WriteLine(numbers[2]);

        numbers[2]=  684;
        Console.WriteLine(numbers[2]);
        
    }
}
