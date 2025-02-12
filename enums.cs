namespace fundamentals
{
    public class MyEnums
    {
        public void myEnums()
        {                                                                                             
        //ENUMS
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
}