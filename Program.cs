using System.Security.Cryptography.X509Certificates;

namespace Project_4__GOOD_ONE_attempt_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.
            
            Part5();

        }
        public static void Part1()
        {
            string name;

            int age;

            double income;

            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name +"! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("So, you're " + age+ ", eh? Heh heh-I remember when you were in diapers! So, how much do you make?");
            Double.TryParse(Console.ReadLine(), out income);

            Console.WriteLine(income. ToString("C") + "! Damn! Maybe you should pick up a few extra shifts, heh heh!");


            
        

       
       




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
            Int32.TryParse(Console.ReadLine(), out studentID);

            Console.Write("What is your average? ");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine();

            Console.WriteLine("login:\t\t" + login);
            Console.WriteLine("ID:\t\t" + studentID);
            Console.WriteLine("Name\t\t" + lastName +", " + firstName);
            Console.WriteLine("Average\t\t" + average + "%");
            Console.WriteLine("Grade\t\t" + grade);
           







        }
        public static void Part3() 
        {


            string name;
            int age, futureAge, pastAge;

            

            


            Console.WriteLine("Hello! What is your name?"); 
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);

            futureAge = age + 5;
            pastAge = age - 5;

            Console.WriteLine("Did you know that in five years you will be " + futureAge + " years old? And five years ago you were " + pastAge + "! Imagine that!"); 


















        }
        public static void Part4() 
        {


            double number1, number2, number3, divided;

            Console.WriteLine("Input a number:");
            Double.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Input another number:");
            Double.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("Input a final number:");
            Double.TryParse(Console.ReadLine(), out number3);

            divided = (number1  + number2 + number3) / 2;

            Console.WriteLine("Calculations complete! You have " + divided + ".");





        }
        public static void Part5() 
        {

            string item1, item2;
            
            double cost1, cost2, totalCost, discount20, discountedCost, taxTotal, finalTotal;

            Console.WriteLine("Hello! Give me a name of something thats on your grocery list!");
            item1 = Console.ReadLine();

            Console.WriteLine("And how much does " + item1 + " Usually cost?");
            Double.TryParse(Console.ReadLine(), out cost1);

            Console.WriteLine("Give me another item on your list.");
            item2 = Console.ReadLine();

            Console.WriteLine("And how much does " + item2 + " normally set you back?");
            Double.TryParse(Console.ReadLine(), out cost2);

            totalCost = cost1 + cost2;

            Console.WriteLine("So those two items will cost you " + totalCost.ToString("C") + ". But luckily for you, you'll get 20% off!");

            discount20 = totalCost * 0.2;

            discountedCost = totalCost - discount20;

            Console.WriteLine("So now, you only have to pay " + discountedCost.ToString("C") + "!");

            taxTotal = discountedCost * 0.13;

            finalTotal = taxTotal + discountedCost;


            Console.WriteLine("Oh, yeah! I almost forgot tax haha! Here's your real final price: " + finalTotal.ToString("C") + ". Have a good day now!");



        }
    }
}
