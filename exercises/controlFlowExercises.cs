namespace fundamentals.exercises
{
    public class ControlFlowExercises
    {
        public void validateNumber()
        {
            Console.WriteLine("Enter a number between 1 and 10.");
            var enteredNumber =Convert.ToInt32(Console.ReadLine());

            if(enteredNumber >1 && enteredNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


        public void displayMaximum()
        {
            Console.WriteLine("Enter the First Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int greaterNumber = firstNumber > secondNumber ? firstNumber :secondNumber; // conditional operator
            Console.WriteLine(greaterNumber);
        }

        public void tellImageOrientation()
        {
            Console.WriteLine("Enter the width of the image:");
            int width  = Convert.ToInt32(Console.ReadLine()); // int.parse() Gives a possible null reference warning and thows an error incase of null hence not preferred

            Console.WriteLine("Enter the height of your image");
            int height  = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientations.landscape: ImageOrientations.portrait;
            Console.WriteLine("The orientation of the image is " + orientation);

        }

        public void speedLimitApp()
        {
            Console.WriteLine("Enter the specified speed limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Current Vehicle speed:");
            int vehicleSpeed = Convert.ToInt32(Console.ReadLine());

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
            else
            {
                Console.WriteLine("You are lucky!");
            }

        }
    }

}