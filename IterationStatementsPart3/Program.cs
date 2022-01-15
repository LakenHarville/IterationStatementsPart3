using System;

namespace IterationStatementsPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();

            PauseConsole();

            PrintThree();

            PauseConsole();

            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();
            bool IsEqual = EqualNumbers(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equal to {userNum2}: {IsEqual}");

            PauseConsole();
            
            int userNum3 = GetAnotherNumber();
            EvenOrOdd(userNum3);
           
            PauseConsole();

            userNum1 = GetUserNumber();
            PositiveOrNegative(userNum1);

            PauseConsole();

            Console.Write("For voting eligibility, enter your age here: \n");
            int age;
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Error! Please try again.");

            }

            AgeChecker(age);

            PauseConsole();

            int userNum4 = GetParameterNumber();
            RangeChecker(userNum4);

            PauseConsole();

            int userNumber;
            int multiplyto = GetUserNumber();
            userNumber = GetUserNumber();
            MultiTable(userNumber, multiplyto);
        }

        private static int GetParameterNumber()
        {
            Console.Write("Checking our parameters for the right number so give me a number between -10 and 10. ");
            int userNum4 = int.Parse(Console.ReadLine());

            return userNum4;
        }

        public static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        private static int GetUserNumber()
        {
            Console.Write("Give me whatever number you think of! ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        private static int GetAnotherNumber()
        {
            Console.Write("Give me another number and lets check to see if it's even or odd. ");
            int anotherNumber = int.Parse(Console.ReadLine());

            return anotherNumber;
        }


        //Write a method that will print to the console all numbers 1000 through -1000.

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void PrintThree()
        {
            for (int a = 3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.

        public static bool EqualNumbers(int num1, int num2)
        {
            return num1 == num2;
        }

        //Write a method to check whether a given number is even or odd.

        public static void EvenOrOdd(int userNum3)
        {
            if (userNum3 % 2 == 0)
            {
                Console.WriteLine($"{userNum3} is even. Good job.");
            }
            else if (userNum3 % 2 != 0)
            {
                Console.WriteLine($"{userNum3} is an odd one, like me!");
            }
            else
            {
                Console.WriteLine($"Did you type zero or something? That doesn't register with me. Best of luck with that one.");
            }

        //Write a method to check whether a given number is positive or negative.           
        }
        private static void PositiveOrNegative(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("This number is without a doubt positive.");

            }
            else
            {
                Console.WriteLine("This number is negative.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        private static void AgeChecker(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("Awesome! You're able to vote!");
            }
            else
            {
                Console.WriteLine("Shame. You're not old enough to vote yet.");
            }

        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10.

        private static void RangeChecker(int userNum4)
        {
            if (userNum4 >= -10 && userNum4 <= 10)
            {
                Console.WriteLine($"{userNum4} is within the correct parameters.");
            }
            else
            {
                Console.WriteLine("This input is not within the wanted parameters.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.

        private static void MultiTable(int userNumber, int multiplyto)
        {
            

            for (int i = 1; i <= multiplyto; i++)
            {
                int product = userNumber * i;
                Console.WriteLine($"{userNumber} * {i} = {product}");
            }
        }
    }
}
