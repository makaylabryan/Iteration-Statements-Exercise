using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            ThreeMultiples();
            NumComps();
            EvenNum();
            PositiveNum();
            VotingAge();
            TenToTen();
            Multiply();
        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 -- DONE
        public static void PrintThousand()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time -- DONE
        public static void ThreeMultiples()
        {
            for(int c = 3; c <= 999; c += 3)
            {
                Console.WriteLine(c);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not -- DONE
        public static bool NumComps()
        {
            Console.WriteLine("Pick any number");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Pick any number again");
            var b = double.Parse(Console.ReadLine());

            var comparison = (a == b);
            if (a == b)
            {
                comparison = true;
                Console.WriteLine($"{a} and {b} are equal in value");
            }
           else 
            {
                comparison = false;
                Console.WriteLine($"{a} and {b} are not equal in value");
            }
            return comparison;
        }

        //Write a method to check whether a given number is even or odd -- DONE
        public static bool EvenNum()
        {
            Console.WriteLine("Give me any whole number");
            var x = double.Parse(Console.ReadLine());

            var even = (x % 2 == 0);
            if (x % 2 == 0)
            {
                even = true;
                Console.WriteLine($"{x} is an even number");
            }
            else
            {
                even = false;
                Console.WriteLine($"{x} is such an odd number, isn't it?");
            }
            return even;
        }

        //Write a method to check whether a given number is positive or negative -- DONE
        public static bool PositiveNum()
        {
            Console.WriteLine("Pick any number, other than zero.");
            var p = double.Parse(Console.ReadLine());

            var positive = (p > 0);
            if (p > 0)
            {
                positive = true;
                Console.WriteLine($"{p} is such a positive response");
            }
            else
            {
                positive = false;
                Console.WriteLine($"Why so negative?");
            }
            return positive;
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()  ---DONE
        public static bool VotingAge()
        {
            Console.WriteLine("How old are you?");
            var o = double.Parse(Console.ReadLine());

            var age = (o >= 18);
            if (o >= 18)
            {
                age = true;
                Console.WriteLine("Yay! You can vote!");
            }
            else
            {
                age = false;
                Console.WriteLine("Sorry! Your too young to vote today.");
            }
            return age;
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 -- DONE
        public static bool TenToTen()
        {
            Console.WriteLine("Type a number");
            var t = double.Parse(Console.ReadLine());

            var ten = (t >= -10 && t <= 10);
            if (t >= -10 && t <= 10)
            {
                ten = true;
                Console.WriteLine($"{t} is within my range.");
            }
            else
            {
                ten = false;
                Console.WriteLine($"Sorry! {t} is out of my range");
            }
            return ten;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer -- DONE
        public static void Multiply()
        {
            int f = 1;
            for (int i = 1; i <= 12; ++i)
            {
                {
                    Console.WriteLine($"{f} * {i} = {f*i}");
                }
            }
             
        }


        //Call the methods to test them in the Main method below

    }
}
