/*
 * Using a while loop iterate through the array of data.
 * 
 * Create a input that will allow the user to select the numbers 1 through 13.
 * 
 * After the user enters allowed number from the string, the data that is on that index is printed out.
 * 
 * Take into account that the index of the string starts from the number zero (0) and it is necessary to adjust the numbers 1-13 in the execution of the program.
 * 
 * In case if user does not enter numbers between 1 and 13, reset the loop and ask them again
 */

#region Test data for the exercise
int fruitIndexer = 0, inputFruitIndexer = 0;


string[] fruits = new string[13]
{
    "Apple",
    "Apricot",
    "Blackberry",
    "Blueberry",
    "Coconut",
    "Grapefruit",
    "Kiwano",
    "Lime",
    "Mango",
    "Nectarine",
    "Clementine",
    "Tangerine",
    "Papaya"
};

#endregion

// Insert your code logic below using while loop
// ==================================================================
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

while (true)
{
    Console.WriteLine("Select the numbers 1 through 13");
    bool validate_input = int.TryParse(Console.ReadLine(), out int result);
    if (validate_input == false)
    {
        Console.WriteLine("Number validation failed, loop is restarting...");
        break;
    }
    else
    {
        inputFruitIndexer = result;
        if (inputFruitIndexer >= 1 && inputFruitIndexer <= 13)
        {
            while (fruitIndexer < fruits.Length)
            {
                if (inputFruitIndexer - 1 == fruitIndexer)
                {
                    Console.WriteLine($"{fruits[fruitIndexer]}");
                }
                fruitIndexer++;
            }
            break;
        }
        else
        {
            Console.WriteLine("Numbers are not between 1 and 13, Try again!");
        }
    }
}

// This is only here to stop the program before exiting
Console.ReadKey();