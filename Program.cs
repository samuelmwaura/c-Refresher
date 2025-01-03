
namespace fundamentals;

public enum ShippingWays
{
    airmail = 1,
    registereAirMail= 2,
    express = 3
}
class Program
{
    static void Main(string[] args)
    {
        //Arrays
        Console.WriteLine("This is for the Lord!");
        int[] numbers = new int[3] { 89, 276,47,}; // can get rid of int[] and use var and compile knows
        Console.WriteLine(numbers[2]); // WriteLine is a static method defined in Console

        numbers[2]=  684;
        Console.WriteLine(numbers[2]);

        //STRING
        //string is a c# keyword that maps to String Class hence has many methods that are static 
        //var can be used for the variable type
        string firstName = "Grenden fill";
        string secondName = "yusufu";
        string fullNames = "My name is " + secondName + " " + firstName;// string by concatenation
        Console.WriteLine(fullNames); // WriteLine accessed directly from the class it is defined.

        string fullNames2 = string.Format("My fullName2 is {0} {1}",firstName,secondName);//string by formatting.format static method
        Console.WriteLine(fullNames2);

        string fullNames3 = string.Join(" ",numbers);// string by joining.Join is a static method
        Console.WriteLine(fullNames3);//no instance of a class is needed

        string path = "Dotnet is located in \n C:\\folder1\\folder2"; //format using verbatim strings to be readable
        String path2 = @"Dotnet is located in 
        C:\\folder1\\folder2";
        Console.WriteLine(path, path2);

        //enums
        var mailingMethod = shippingWays.registeredAirMail;
        Console.WriteLine((int)mailingMethod); //outputting the mailing method's respective integer value

        int receivedMethodIdentifier = 1;
        Console.WriteLine((shippingWays)receivedMethodIdentifier); //change a received integer to the respective shipping way defined in the our app.We cast the received number into the enum

        Console.WriteLine(shippingWays.express.ToString());//Method calls toStrings everytime,no need to call tostrings

        string receivedStringMethod = "airMail";
        var parsedReceivedStringMethod = (shippingWays)Enum.Parse(typeof(shippingWays),receivedStringMethod);//
        //first  parse the string to the type of the specified enum then cast the resultant object using the specified enum
        //parse -  change a string to another type
        Console.WriteLine(parsedReceivedStringMethod);



    }
}
