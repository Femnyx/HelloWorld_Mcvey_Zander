using System;

namespace HelloWorld_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {/* Ask for the User's firstName */
            Console.WriteLine("Hello, what is your first name Stranger?");
             string firstName = Console.ReadLine();
         /* Next, ask for the User's lastName*/
            Console.WriteLine("Interesting, What is your last name?");
             string lastName = Console.ReadLine();
         /* Make it seem like you sorta know this person*/
            Console.WriteLine($"{firstName} {lastName}, yes, you seem...Familiar");

            
        }
    }
}
