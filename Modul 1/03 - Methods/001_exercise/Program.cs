/*
 * Using only methods, create a simple application inside the Program class to count the number of spaces in a string
 * 
 */

namespace _001_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        string sentence;

        Console.Write("Entering a sentence: ");
        sentence = Console.ReadLine();

        /*
         * Help:
         * Step 1: create a method that accepts a single parameter of type string
         * Step 2: pass the entered string to the method as an argument
         * Step 3: inside the method it is possible to create a loop that will iterate through the string of characters
         * Step 4: inside the loop it is possible to check if the character is a space
         * 
         */


        // Insert your code logic below
        // ==================================================================

        CountSpaces(sentence);

        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
    // Insert your methods inside class Program
    // ==================================================================
    public static void CountSpaces(string sentence)
    {
        int counter = 0;
        foreach (char letter in sentence)
        {
            if (letter == ' ')
                counter++;
        }
        Console.WriteLine("Number of white spaces in sentence is: " + counter);
    }
}