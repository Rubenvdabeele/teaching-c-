namespace Chapter1{
    // Colon notation, Student is a Subclass of Person
    // ClassB : ClassA - classB is a SUBclass of classA
    // or: Student extends Person
    // or: Students Inherits from Person
    // or: Student is a Subclass of Person
    class Student : Person{

        protected string EnrolledIn{get;set;}

        // Base constructor: Student reuses the constructor of its parent class
        // base() keyword, called just like the Person constructor
        // If the parent has more than one (overloaded) constructor, any can be used.
        // The compiler will tell you if all required data has been set in the constructor of a child class.
        // ! You need to know some of the details of the parent class!
        // ! The compiler and the IDE will help you though.
        public Student(string firstname, string lastname, string enrolledIn) : base(firstname, lastname){
            EnrolledIn = enrolledIn;
        }

        public void SayNameAndStudy()
        {
            // We can access all the protected members of the parent class!
            string sayNameString = String.Format("My name is: {0} {1}, and I study: {2}", Firstname, Lastname, EnrolledIn);
            Console.WriteLine(sayNameString);
        }
    }
}