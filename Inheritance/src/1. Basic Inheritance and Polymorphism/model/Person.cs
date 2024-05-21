

namespace Chapter1{
    public class Person(string firstname, string lastname)
    {
        protected string Firstname { get; set; } = firstname;
        protected string Lastname { get; set; } = lastname;

        public void SayName(){
            string sayNameString = String.Format("My name is: {0} {1}", Firstname, Lastname);
            Console.WriteLine(sayNameString);
        }
    }
}