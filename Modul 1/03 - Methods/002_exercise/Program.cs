/*
 * Using only methods, create a simple application inside the Program class for exchanging the places of the largest and smallest numbers within an array 
 * 
 */

namespace _002_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        /*
         * Help:
         * Step 1: enter 10 numbers and save values in array
         * Step 2: pass a array of numbers to the method as an argument
         * Step 3: inside the method it is possible to create a loop that will iterate through the array of numbers
         * Step 4: with the help of additional variables, it is possible to find the largest and smallest number of the sequence, as well as the index of that sequence
         * Step 5: use array index value to switch places with the largest and smallest numbers
         * 
         */

        int[] numbers = new int[10];

        // Insert your code logic below
        // ==================================================================
        int i = 0;
        for (i = 0; i < 10; i++)
        {
            numbers[i] = EnterNumbers(i);
        }
        Console.WriteLine("Array before sorting: ");
        PrintArray(numbers);
        Console.WriteLine("===================");
        SortNumbers(numbers);
        Console.WriteLine("Sorted array: ");
        PrintArray(numbers);
        Console.WriteLine("===================");
        Console.WriteLine($"Smallest number of the array: {numbers[0]}");
        Console.WriteLine($"Largest number of the array: {numbers[numbers.Length -1]}");

        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
    // Insert your methods inside class Program
    // ==================================================================
    public static int EnterNumbers(int i)
    {
        int num = 0;
        int parsedInteger = 0;
        string number = String.Empty;
        while (int.TryParse(number, out parsedInteger) == false)
        {
            Console.WriteLine($"Please enter {i + 1} number");
            number = Console.ReadLine();
        }
        return parsedInteger;
    }

    public static void PrintArray(int[] numberArray)
    {
        foreach (int number in numberArray)
        {
            Console.Write(number + " ");
        }
    }

    public static void SortNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
    }
}