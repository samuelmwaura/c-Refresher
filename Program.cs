﻿using fundamentals.exercises;
using fundamentals.objectOriented;
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

        var newPoint = new Point(80,60);
        newPoint.move(40, 50);
        newPoint.move(new Point(80,70));
        Console.WriteLine("These are the new points:{0} {1}",newPoint.x, newPoint.y);
        
    }
}
