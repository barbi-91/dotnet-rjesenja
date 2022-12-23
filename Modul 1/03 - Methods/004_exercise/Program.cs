using System.Collections;

/*
 * Using only methods, create a simple application inside the Program class to solve the problem of organizing and printing data of the same types
 * 
 */

namespace _004_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        ArrayList first_unorganized_list = new ArrayList()
        {
            "Mike",
            "Ana",
            0,
            "(",
            22,
            null,
            107.55F,
            "More than 50% off today only!",
            205.33D,
            -30,
            "Someone ate my chocolate...",
            104,
            "",
            "",
            ',',
            true,
            true,
            (-11 + 100),
            -30,
            "Weekend soon :)",
            0,
            (45+2),
            false,
            "",
            "Quantity discount",
            true,
            '.'
        };

        ArrayList second_unorganized_list = new ArrayList()
        {
            "Programmer",
            "!",
            ')',
            -222222222,
            null,
            false,
            107.55F,
            205.33D,
            104,
            "",
            "",
            true,
            "Today is a beautiful and sunny day!",
            true,
            -11,
            -30,
            0,
            "",
            '!',
            'k',
            4284729847238947274,
            '9',
            (45+2-1000),
            "Where is my method?",
            false,
            "",
            0,
            true,
            ".",
            1000000000.00000000000000
        };


        List<int> list_of_integers = new List<int>();
        List<decimal> list_of_decimal_numbers = new List<decimal>();
        List<char> list_of_character = new List<char>();
        List<string> list_of_strings = new List<string>();
        List<bool> list_of_booleans = new List<bool>();

        /*
         * Help:
         * Step 1: pass the list you want to organize as an argument to the method
         * Step 2: inside the method it is possible to create a loop that will iterate through the individual value
         * Step 3: for each iteration it is possible to check the data type
         * Step 4: if the value is null, skip it. Save all other values in the corresponding lists
         * Step 5: use documentation for type comparison and type conversion 
         * 
         * Step 6: after the process of organizing the list is finished, it is necessary to offer the user some options
         * Available options for choosing to print the list:
         *      Option yes - selecting this option opens additional options:
         *                  1 - print everything from the list of integers
         *                  2 - print everything from the list of decimal numbers
         *                  3 - print everything from the list of string
         *                  4 - print everything from the list of characters
         *                  5 - print everything from the list of booleans
         *
         *      Option no - exits and ends the program
         * 
         * 
         * 
         * Type comparison documentation: https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-6.0
         * Type conversion documentation: https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-6.0
         */
        OrganizeList(first_unorganized_list, list_of_strings, list_of_integers, list_of_booleans, list_of_character, list_of_decimal_numbers);
        OrganizeList(second_unorganized_list, list_of_strings, list_of_integers, list_of_booleans, list_of_character, list_of_decimal_numbers);

        int operation = 0;
        Console.WriteLine("Do you want to print the list ? (yes/no)");
        string? print = Console.ReadLine()?.ToLower();

        if (print == "yes")
        {
            while (true)
            {
                Console.WriteLine("Available options for choosing to print the list (type 'no' to exit): ");
                Console.WriteLine();
                Console.WriteLine(" * 1 - print everything from the list of integers \n * 2 - print everything from the list of decimal numbers \n * 3 - print everything from the list of string  \n * 4 - print everything from the list of characters  \n * 5 - print everything from the list of booleans");
                Console.WriteLine();
                Console.WriteLine("Enter your choice: ");

                string? chosenOperation = Console.ReadLine()?.ToLower();
                if (chosenOperation == "no")
                {
                    Console.WriteLine("You chose to exit program, goodbye!");
                    return;
                }

                bool valid = int.TryParse(chosenOperation, out operation);
                if (valid == false || operation < 1 || operation > 5)
                {
                    Console.WriteLine("Wrong input value! Program will exit! ");
                    return;
                }
                else
                {
                    Console.WriteLine("Values of list are:");
                    PrintList(operation, list_of_strings, list_of_integers, list_of_booleans, list_of_character, list_of_decimal_numbers);
                    Console.WriteLine("===============================");
                }
            }
        }
        else
        {
            Console.WriteLine("Program has ended!");
            return;
        }
    }

    // Insert your methods inside class Program
    // ==================================================================
    public static void OrganizeList(ArrayList listOfValues, List<string> stringList, List<int> intList, List<bool> boolList, List<char> charList, List<decimal> decimalList)
    {
        foreach (var value in listOfValues)
        {
            if (value == null)
            {
                continue;
            }
            else
            {
                Type t = value.GetType();
                if (t.Equals(typeof(string)))
                {
                    stringList.Add((string)value);
                }
                else if (t.Equals(typeof(char)))
                {
                    charList.Add((char)value);
                }
                else if (t.Equals(typeof(int)))
                {
                    intList.Add((int)value);
                }
                else if (t.Equals(typeof(bool)))
                {
                    boolList.Add((bool)value);
                }
                else if (t.Equals(typeof(decimal)))
                {
                    decimalList.Add((decimal)value);
                }
                else
                    Console.WriteLine("'{0}' is another data type: {1}.", value, t);
            }
        }
    }

    public static void PrintList(int operationNum, List<string> stringList, List<int> intList, List<bool> boolList, List<char> charList, List<decimal> decimalList)
    {
        int count = 0;
        switch (operationNum)
        {
            case 1:
                count = intList.Count();
                foreach (var item in intList)
                {
                    Console.WriteLine(item);
                }
                break;
            case 2:
                count = decimalList.Count();
                foreach (var item in decimalList)
                {
                    Console.WriteLine(item);
                }
                break;
            case 3:
                count = stringList.Count();
                foreach (var item in stringList)
                {
                    Console.WriteLine(item);
                }
                break;
            case 4:
                count = charList.Count();
                foreach (var item in charList)
                {
                    Console.WriteLine(item);
                }
                break;
            case 5:
                count = boolList.Count();
                foreach (var item in boolList)
                {
                    Console.WriteLine(item);
                }
                break;

            default:
                Console.WriteLine("Invalid operation code!");
                return;
        }
        Console.WriteLine("***************************************");
        Console.WriteLine($"Count of elements in a list: {count}");
    }
}
