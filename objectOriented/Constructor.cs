using System.Collections.Generic;
namespace fundamentals.objectOriented
{
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public List<Order> orders; //generic list of orders of type orders
             
    
        public Person()// Default contructor{no parameters}.constructor sets an object in an initial state
        {
            
        }
        //method called when an instance of a class is created to initialize an object
        //No return type
        //Even when not declared, C# creates it in the runtime.it does so to initialize the fields of the class to their default values e.g. numbers to zero, boolean to false
        //default consumer created by runtime ceas to be functional when custom ccp
        public Person(string firstName, string middleName, string lastName) // parameterized constructor
        {
            this.firstName = firstName; //this keyword references the currenct object.
            this.middleName = middleName;
            this.lastName = lastName;
        }
    }
}