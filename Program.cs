using System.Security.Cryptography.X509Certificates;

namespace Project_4__GOOD_ONE_attempt_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.
            
            Part2();

        }
        public static void Part1()
        {
            string name;

            int age;

            double income;

            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name +"! How old are you?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));

            Console.WriteLine("So, you're " + age+ ", eh? Heh heh-I remember when you were in diapers! So, how much do you make?");
            Double.TryParse(Console.ReadLine(), out income);

            Console.WriteLine(" $" + income + "! Damn! Maybe you should pick up a few extra shifts, heh heh!");


            
        

       
       




        }
        public static void Part2() 
        {
            Console.WriteLine("Please enter the following information so I can sell it for a profit!");
            Console.WriteLine();

            string firstName, lastName;

            int  studentID, login;

            double average, grade;

            Console.Write("What's your login info? ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out login));

            Console.Write("What's your first name? ");
            firstName = Console.ReadLine();

            Console.Write("And what is your last name, " + firstName + "? ");
            lastName = Console.ReadLine();

            Console.Write("Well, hello, " +firstName + " " + lastName +"! What grade are you in? ");
            Double.TryParse(Console.ReadLine(), out grade);

            Console.Write("What is your student ID? ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentID));

            Console.Write("What is your average? ");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine();

            Console.WriteLine("login:\t\t" + login);
            Console.WriteLine("ID:\t\t" + studentID);
            Console.WriteLine("Name\t\t" + lastName + firstName);
            Console.WriteLine("Average\t\t" + average);
            Console.WriteLine("Grade\t\t" + grade);
           







        }



    }
}
