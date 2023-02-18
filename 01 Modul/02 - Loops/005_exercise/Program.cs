/*
 * Create a simple program that will accept one sentence input.
 * Using a for loop use input characters to arrange them in ascending order
 */

#region This is here only to help you plan your input and sorting

using System.Collections;

string sentence;
char[] array_of_characters;
int i, j, length;

#endregion

Console.Write("Enter a sentence: ");
sentence = Console.ReadLine();//.ToLower();
length = sentence.Length;
array_of_characters = sentence.ToCharArray(0, length);



// Insert your code logic below using for loop
// ==================================================================

// solution 1
//Array.Sort(array_of_characters, (c1, c2) => string.Compare(c1.ToString(), c2.ToString(), StringComparison.CurrentCultureIgnoreCase));
//Console.WriteLine(array_of_characters);

//solution 2
// Sorting using a single loop
//for (j = 0; j < length - 1; j++)
//{

//    // Checking the condition for two
//    // simultaneous elements of the array
//    if (array_of_characters[j] > array_of_characters[j + 1])
//    {

//        // Swapping the elements.
//        char temp = array_of_characters[j];
//        array_of_characters[j] = array_of_characters[j + 1];
//        array_of_characters[j + 1] = temp;

//        // updating the value of j = -1
//        // so after getting updated for j++
//        // in the loop it becomes 0 and
//        // the loop begins from the start.
//        j = -1;
//    }
// }
//Console.WriteLine(new string(array_of_characters));





// This is only here to stop the program before exiting
Console.ReadKey();