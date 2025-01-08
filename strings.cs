namespace fundnamentals
{
    public class MyStrings()
    {
        public void myStrings()
        {
              //STRINGS
        //string is a c# keyword that maps to String Class hence has many methods that are static 
        //var can be used for the variable type
        string firstName = "Grenden fill";
        string secondName = "yusufu";
        var numbersArray  = new int[3]{3,5,6};
        string fullNames = "My name is " + secondName + " " + firstName;// string by concatenation
        Console.WriteLine(fullNames); // WriteLine accessed directly from the class it is defined.

        string fullNames2 = string.Format("My fullName2 is {0} {1}",firstName,secondName);//string by formatting.format static method
        Console.WriteLine(fullNames2);

        string fullNames3 = string.Join(" ",numbersArray);// string by joining.Join is a static method
        Console.WriteLine(fullNames3);//no instance of a class is needed

        string path = "Dotnet is located in \n C:\\folder1\\folder2"; //format using verbatim strings to be readable
        String path2 = @"Dotnet is located in 
        C:\\folder1\\folder2";
        Console.WriteLine(path, path2);

        }
    }
}