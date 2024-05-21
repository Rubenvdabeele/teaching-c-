

namespace Chapter1
{
    // This class is an example of what not to do!
    public class Student_NoInheritance(string firstname, string lastname, string enrolledIn)
    {
        // A student is a person, so they have names!
        string Firstname { get; set; } = firstname;
        string Lastname { get; set; } = lastname;

        string EnrolledIn { get; set; } = enrolledIn;

        // This code is a copy of that in Person.cs
        public void SayName()
        {
            string sayNameString = String.Format("My name is: {0} {1}", Firstname, Lastname);
            Console.WriteLine(sayNameString);
        }

        public void SayNameAndStudy()
        {
            string sayNameString = String.Format("My name is: {0} {1}, and I study: {2}", Firstname, Lastname, EnrolledIn);
            Console.WriteLine(sayNameString);
        }
    }
}