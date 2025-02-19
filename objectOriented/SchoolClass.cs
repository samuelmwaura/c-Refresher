namespace fundamentals.objectOriented
{
    public class SchoolClass
    {
        public int numberOfStudents;
        public int numberOfCourses;
        
        //For a method that has a varying number of parameters, we can modifiy the parameters using the keyword params that will allow passing of a varied number of parameters whenever called.
        //We can also modify a parameter with ref to make sure that a value type is treated like a reference type
        public void calculateTotalMarks(params int[] marks) // params before a parameter means it can take a varied no
        {

        }
    }
}