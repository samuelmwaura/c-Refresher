using System.Runtime.CompilerServices;
using fundamentals.exercises;
using System;
using fundnamentals;
using System.Text;
using System.Globalization;
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

         //WORKING WITH STRINGS
         var myTestSentence = "  This is the sentence that I will be using to write and to test strings sentence.  ";
         Console.WriteLine("This is the value of the string Trimmed:{0}:",myTestSentence.Trim());
         Console.WriteLine("This is the index of the word 'Sentence': {0}",myTestSentence.IndexOf("sentence"));
         Console.WriteLine("This is is the index of the last 'sentence' word: {0}",myTestSentence.LastIndexOf("sentence"));
         Console.WriteLine("This is a substring from the first word 'Sentence':{0}",myTestSentence.Substring(myTestSentence.IndexOf("sentence")));

         foreach(var word in myTestSentence.Split()) // Split gives a string array of words
         {
            Console.WriteLine(word);

         }

         Console.WriteLine("Replacing 'Sentence' with 'Clause':{0}",myTestSentence.Replace("sentence","clause")); // .replace returns a new string with the changed values.
         System.Console.WriteLine("My strung is null or empty: {0}", String.IsNullOrEmpty(myTestSentence));
         System.Console.WriteLine("My strung is null or Whitespace: {0}", String.IsNullOrEmpty(myTestSentence));

         //Converting Strings
         var stringNumber = "678893";
         var number = 3457;

         Console.WriteLine("This is my number from string:{0}",Convert.ToInt32(stringNumber));
         Console.WriteLine("This is my String from number:{0}",number.ToString("C")); // Converts to currency format

         //using stringbuilder class - A class to create mutable strings but not optimized for searching
         var stringBuilderExample = new StringBuilder();
         Console.WriteLine(stringBuilderExample.Append('k',12));
         System.Console.WriteLine(stringBuilderExample.Replace("k","o"));
         System.Console.WriteLine(stringBuilderExample.Remove(0, 5)); //removes from index 0  5 elements
         System.Console.WriteLine(stringBuilderExample.Insert(0,new  String(" ENTER THIS NEW ")));



    }
}
