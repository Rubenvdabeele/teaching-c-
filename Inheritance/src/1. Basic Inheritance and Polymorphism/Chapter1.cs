// Disable warning for shortened constructors for clarity.
#pragma warning disable IDE0090 // Use 'new(...)'

namespace Chapter1
{
    static class Chapter1
    {
        public static void RunChapter()
        {
            // -------- INHERITANCE -------------

            // Peter is a person and they have a name and he can say it.
            // Peter is not studying anything.
            Person peter = new Person("Peter", "Kessels");
            peter.SayName();

            // Examine the Person class, take a look at what it can and can't do.

            // Now let's introduce Carmen. They are a person and a student.
            // This means they are enrolled in a Course. There's no room for that data in the Person class.
            // We could add it to the Person class, however, Peter is not a student
            // So Peter has no need for that data.
            // We need to create a new class to accomodate both types of objects, representing Peter & Carmen.
            // So, we naively create a new class, Student_NoInheritance.
            // As the name suggest, we will not use inheritance.
            Student_NoInheritance carmen = new Student_NoInheritance("Carmen", "Han", "Computer science");
            carmen.SayName();
            carmen.SayNameAndStudy();

            // Take a look at the class "Student_NoInheritance" and compare it to Person.
            // You'll notice a lot of code is the same.
            // That's code Duplkication, wich we want to avoid at all costs.
            // It creates all sorts of problems, for example:
            // What if we want to change the way the SayName() works?
            // We would have to adapt the code in 2 places.
            // What if we want to introduce a class for an Employee of the school?
            // Then we have code duplication in 3 classes, including the Employee class.

            // --> INHERITANCE to the rescue.

            // Hannah is a Student can do everything Peter can, and what Carmen can:
            // Without code duplication!
            Student hannah = new Student("Hannah", "Gillot", "Chemistry");
            hannah.SayName();
            hannah.SayNameAndStudy();

            // Student INHERITS from Person. Go take a look in the Student class to see how that is done.

            // Notice that the access on the members of Person are "Protected"
            // Protected is like private, with an exception for classes inheriting from the class
            // Public members: accessible in and outside the class
            // Private member: accessible only in the class
            // Protected members: accessible only in the class and to children of the class, not outside
            // If the members on Person were private, our Student class could not use them.
            // REMEMBER: Private is the default access modifier! When you don't specify, it's private.

            // Now the real trick! We have prevented duplicating code, but in the process we also gained:


            // ------------- POLYMORPHISM ---------------------

            //Take a look at this:
            Person[] roomA = [peter, hannah];

            // Peter a Person, and Hannah, a Student, can be stored in the same array, representing "room A"!
            // This allows us to to fun things like:
            // Asking everyone in the room to say their name
            Console.WriteLine("Hey everyone in Room A, say your name!");
            foreach (Person person in roomA)
            {
                person.SayName();
            }

            // The above foreach loop is a nicer way to write:
            Console.WriteLine("Hey everyone in Room A, say your name again!");
            for (int i = 0; i < roomA.Length; i++)
            {
                Person person  = roomA[i];
                person.SayName();
            }

            // This wont work!
            Console.WriteLine("Hey everyone in Room A, say your name and what you study!");
            foreach (Person p in roomA)
            {
                p.SayName();

                // This is a room full of Persons!
                // Not all of them might be students. In fact, we know Peter is not a student.
                // p.SayNameAndStudy();
            }

            // This won't work either:
            // (Uncomment to see the error)
            Student[] roomForStudents = [hannah /*, peter*/]; // Peter doesn't fit in the room!
            // Because we created a room for students only.
            // This means polymorphism only works downward, the more specific the requirement wins.
            // For example: Bears and humans are animals, but a Bus only fits humans. (And dogs, maybe cats.)

            // Neither will this:
            // (Uncomment to see the error)
            // Carmen doesn't fit in the room, even though she meets all the requirements.
            // The compiler doesn't know this, because she doesn't inherit from Person.
            // We are free to change the code in Student_NoInheritance and create incompatibilities with Person!
            Person[] roomZ = [peter, hannah /*, carmen*/]; // Carmen doesn't fit in the room!

            // NEXT:
            // Abstract base classes
            // Overriding virtual methods
            // The Object superclass to everything
            // Casting (& runtime errors)
        }
    }
}