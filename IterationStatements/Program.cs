namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thousand();

            PrintThree();

            Console.WriteLine(IsEqual(4, 6));

            int number = 5;
            int a = 8;
            Console.WriteLine($"{number} is {(IsEven(number) ? "even" : "odd")}");

            Console.WriteLine($"{a} is {(IsPositive(number) ? "positive" : "negative")}");

            // Prompt the user to enter age

            Console.Write("Enter your age: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            Console.WriteLine($"{age} {(CanVote(age) ? "you can vote" : "you can not vote")}");

            //to check if an integer(from the user) is in the range -10 to 10

            Console.WriteLine($" Enter an integer");
            string userNum;
            int num;
            bool doIt;
            
            do
            {
                Console.WriteLine("is your number between -10 and 10? type a number...");
                userNum = Console.ReadLine();
                doIt = int.TryParse(userNum, out num);
            } while (!doIt);
            IsInRange(num);
           

                
            //to check if an integer(from the user) is in the range -10 to 10
           // Console.WriteLine($" Enter an integer");
           
           //int userInput = int.Parse(Console.ReadLine());
          //IsInRange(number);
            Console.WriteLine();


           // int userInput = int.Parse(Console.ReadLine());
           // IsInRange(number);
            Console.WriteLine();
            //multiplication table from 1 to 12
            Console.WriteLine($"Multiplication Table for {13}:");
            int num2 = 13;
            DisplayMultiplicationTable(num2);
            Console.WriteLine();

        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Thousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintThree()
        {
            for (int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int num1, int num2)
        {

            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int a)
        {
            if (a >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()


        public static bool CanVote(int age)
        {
            // Check if the age is greater than or equal to the voting age 18
            return age >= 18;

            if (CanVote(age))
            {

                Console.WriteLine($"{age} You can vote.");
            }
            else
            {
                Console.WriteLine($"{age} You cannot vote yet.");
            }


        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInRange(int num)
        {
            
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine("The number is within the range -10 to 10.");
                return true;
            }
            else
            {
                Console.WriteLine("The number is not within the range -10 to 10.");
                return false;
            }
            
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable(int num)
        {

            //Console.WriteLine($"Multiplication Table for {num}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{13} * {i} = {13 * i}");
            }

            //Call the methods to test them in the Main method below


        }
    }
}