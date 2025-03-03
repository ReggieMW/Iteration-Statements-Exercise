namespace IterationStatements
{
    public class Program
    {
        //heatin' up 1
        static bool IsNumberInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        static void Main(string[] args)
        {
            PrintNumbers(1000, -1000);
            PrintEveryThirdNumber(999, 3);
            
//all numbers 1000 to -1000
            static void PrintNumbers(int topNum, int bottomNum)
            {
                for (var i = topNum; i >= bottomNum; i--)
                {
                    Console.WriteLine(i);
                }
            }
            
//printing every third number
            static void PrintEveryThirdNumber(int topNumber, int bottomNumber)
            {
                for (var i = bottomNumber; i <= topNumber; i += 3)
                {
                    Console.WriteLine(i);
                }
            }
            
//check to see if numbers are equal
            int number1 = 5;
            int number2 = 9;

            bool areEqual = AreNumbersEqual(number1, number2);
            Console.WriteLine("Are the numbers equal?" + areEqual);

            static bool AreNumbersEqual(int number1, int number2)
            {
                return number1 == number2;
            }
            
//check to see if even or odd

            static bool IsEven(int numOne)
            {
                return numOne % 2 == 0;
            }

            int numOne = 266;
            bool evenNumber = IsEven(numOne);
            Console.WriteLine(evenNumber ? numOne + " is even" : numOne + " is odd");
            
//check if a number is positive or negative

            static bool IsPositive(int numberInQuestion)
            {
                return numberInQuestion > 0;
            }

            static bool IsNegative(int numberInQuestion)
            {
                return numberInQuestion < 0;
            }

            int numberInQuestion = 0;

            if (IsPositive(numberInQuestion))
            {
                Console.WriteLine($"{numberInQuestion} is positive.");
            }
            else if (IsNegative(numberInQuestion))
            {
                Console.WriteLine($"{numberInQuestion} is negative.");
            }
            else
            {
                Console.WriteLine($"{numberInQuestion} is zero.");
            }

//voting age check
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            static bool CanVote(int age)
            {
                return age >= 18;
            }

            if (CanVote(age))
            {
                Console.WriteLine("Can vote.");
            }
            else
            {
                Console.WriteLine("Can't vote.");
            }
//is number between -10 & 10?
            Console.WriteLine("Please enter a whole number: ");
            int number = int.Parse(Console.ReadLine());
            int min = -10;
            int max = 10;

            bool isInRange = IsNumberInRange(number, min, max);
            if (isInRange)
                Console.WriteLine("You sunk my battleship!");
            else
                Console.WriteLine("You missed! My turn.");

// 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.

            DisplayMultiplicationTable(413);

            static void DisplayMultiplicationTable(int numero)
            {
                Console.WriteLine($"Multiplication table for {numero}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"\t{i} * {numero} = {numero * i}");
                }
            }
        }
    }
}