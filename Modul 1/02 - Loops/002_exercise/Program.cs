/*
 * Using a while loop iterate through the array of data and 
 * print each piece of data to the console
 */

#region Test data for the exercise
int fruitIndexer = 0;
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

while (fruitIndexer < fruits.Length)
{
    Console.WriteLine($"{fruits[fruitIndexer]}");
    fruitIndexer++;

}


// This is only here to stop the program before exiting
Console.ReadKey();