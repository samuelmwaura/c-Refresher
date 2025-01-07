
namespace fundamentals
{
    public class Program
    {
        public static void Main(String[] args)  //change entry point by renaming
        {
            //validate input
            Console.WriteLine("Enter a number.");
            int enteredNumber = int.Parse(Console.ReadLine());

            if(enteredNumber >10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

             //display maximum of two entered numbers
            Console.WriteLine("Enter the First Number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int greaterNumber = firstNumber > secondNumber ?firstNumber :secondNumber; // conditional operator
            Console.WriteLine(greaterNumber);

            //Tell the image orientation

            Console.WriteLine("Enter the width of the image:");
            int width  = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of your image");
            int height  = int.Parse(Console.ReadLine());

            string orientation = width > height ? "landScape": "portrait";
            Console.WriteLine("The orientation of the image is " + orientation);

            //Speed limit program
            Console.WriteLine("Enter the specified speed limit:");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Current Vehicle speed:");
            int vehicleSpeed = int.Parse(Console.ReadLine());

            if (vehicleSpeed < speedLimit)
            {
                Console.WriteLine("Ok"); 
            }
            else if (vehicleSpeed > speedLimit)
            {
                int demeritPoints = (vehicleSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(demeritPoints);               
                }

            }


        }
        
    }
}