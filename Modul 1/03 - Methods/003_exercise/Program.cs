/*
 * Using only methods, create a simple application inside the Program class to calculate the sum of the individual digits of a number
 * 
 */

namespace _003_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        int number;
        Console.Write("Enter a number: ");
        string validate_number = Console.ReadLine();

        bool validacion = int.TryParse(validate_number, out int parsedNumber);
        if (validacion == true)
        {
            number = parsedNumber;
            Console.WriteLine($" Sum of the individual digits of a number is: {CountDigit(number)}");
        }
        /*
         * Help:
         * Step 1: validate input
         * Step 2: pass a number to the method as an argument
         * Step 3: inside the method it is possible to create a loop that will iterate through the individual digits of the number
         * Step 4: sum of the individual digits and return result
         * 
         */


        // This is only here to stop the program before exiting
        Console.ReadKey();
    }

    // Insert your methods inside class Program
    // ==================================================================
    static int CountDigit(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}