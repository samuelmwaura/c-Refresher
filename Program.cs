using System.Runtime.CompilerServices;
using fundamentals.exercises;
using System;
namespace fundamentals;

class Program
{
    static void Main(string[] args)
    {
        // //Arrays
        // var myArrays = new MyArrays();
        // myArrays.myArrays();

        // //enums
        // var enums = new MyEnums();
        // enums.myEnums();

        // //control flows
        // var ifAndSwitch = new ControlFlow();
        // ifAndSwitch.controlFlow();


        // //control flow exercises
        // var controlFlowExercises = new ControlFlowExercises();
        // controlFlowExercises.validateNumber();
        // controlFlowExercises.displayMaximum();
        // controlFlowExercises.tellImageOrientation();
        // controlFlowExercises.speedLimitApp();

        //Loops exercises
        //var loopExercises = new loopExercises();
        //loopExercises.findDivisiblesBy3();
        //loopExercises.sumAllEnteredNumbers();
        //loopExercises.factorialinLoops();
        //loopExercises.randomGuessing();

        // var njeru = new Person("Erastus","Mbau","Ngure"); // initialization using a constructor
        // Console.WriteLine("These are the names of the Person in question: {0} {1} {2}",njeru.firstName,njeru.middleName,njeru.lastName);

        //STRING METHODS
        var longSentence = "dfbuudihd heiodjs oaijsojd woijdopj kdpoask dpoasd cmaknc ajdnuw eiudh weiodj owedj paodjad";
        Console.WriteLine(StringUtility.SummarizeSentence(longSentence, 28));

        //WORKING WITH DATES
        var adate = new DateTime(1998,3,27);
        Console.WriteLine("The hours now are:{0} and the minutes are {1}",DateTime.Now.Hour,DateTime.Now.Minute);  
         //Datetimes are immutable.only modified using methods that all start with add
         Console.WriteLine("Tomorrow is {0} and yesterday was {1}",DateTime.Now.AddDays(1), DateTime.Now.AddDays(-1));
         Console.WriteLine("Long Date String: {0}",DateTime.Now.ToLongDateString());
         Console.WriteLine("Short Date String: {0}",DateTime.Now.ToShortDateString());
         Console.WriteLine("Long time String: {0}",DateTime.Now.ToLongTimeString());
         Console.WriteLine("Short Date String: {0}",DateTime.Now.ToShortTimeString());
         Console.WriteLine("This is the long date format, String and time: {0}", DateTime.Now.ToString());
         Console.WriteLine("This is the long date format with format specifiers: {0}",DateTime.Now.ToString("yyyy-MM-dd HH:mm"));// there are other format specifiers in the documentation.

         //WORKING WITH TIMESPANS - a length of time.
         //Creating
         var timespan = new TimeSpan(3,57,58); //hh mm ss
         Console.WriteLine("This is another way to create Timespans: {0}",TimeSpan.FromHours(7));
         Console.WriteLine("This is the last way to create a Timespan: {0}",DateTime.Now - DateTime.Now.AddDays(-1));

         //Properties
         Console.WriteLine("This is the minutes property of our timespan: {0}, While this is the timespan expressed as minutes:{1}", timespan.Minutes, timespan.TotalMinutes);

         //Add - timespans are immutable and their value can only be changed by using methods
         Console.WriteLine("This is how to add to timespan: {0}",timespan.Add(new TimeSpan(4,5,8))); // add method takes a timespan
         Console.WriteLine("This is a timespan to a string:{0}",timespan.ToString());
         Console.WriteLine("This is a timespan from a string:{0}", TimeSpan.Parse("7:56:57"));
         

    }
}
