namespace fundamentals
{
    public class MyArrays
    {
        public void myArrays()
        {
            //Arrays
        Console.WriteLine("This is for the Lord!");
        int[] numbers = new int[3] { 89, 276,47,}; // can get rid of int[] and use var and compile knows
        Console.WriteLine(numbers[2]); // WriteLine is a static method defined in Console

        numbers[2]=  684;
        Console.WriteLine(numbers[2]);
        }
    }
}