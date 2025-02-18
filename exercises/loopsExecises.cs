namespace fundamentals.exercises;

public class loopExercises
{

    public void findDivisiblesBy3()
    {
        int counter = 0;
        int i = 1;
        while (i < 100)
        {
            if (i % 3 == 0)
                counter++;
            i++;
        }
        Console.WriteLine(counter);
    }


    public void sumAllEnteredNumbers()
    {
        int sum = 0;
        while (true)
        {
            Console.WriteLine("Enter a number:");
            var input = Console.ReadLine();
            if (input == "ok")
            {
                break;
            }
            else
                sum += Convert.ToInt32(input);
        }

        Console.WriteLine(sum);
    }

    public void factorialinLoops()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        long factorial = i;
        while (i <= number)
        {
            factorial *= i;
            i++;
        }
        Console.WriteLine(factorial);
    }

    public void randomGuessing()
    {
        int reference = new Random().Next(1, 10); // generate a random number between 1 and 10
        Console.WriteLine("The reference number is: " + reference);
        int i = 0;

        while (i < 4)
        {
            Console.WriteLine("Pass your guess for the random number:");
            if (!(reference == Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("You Lost");
                i++;
                continue;
            }
            else
            {
                Console.WriteLine("You Won");
                break;
            }

        }
    }

    public void findLargestInput()
    {
        Console.WriteLine("Enter a Series of Numbers Separated by Commas:");
        var input = Console.ReadLine();

        input.Split()


    }



}