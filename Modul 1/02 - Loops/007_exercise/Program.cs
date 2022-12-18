/*
 * Using a foreach loop find the number of occurrences of a character in the sequence
 */

// Insert your code logic below using foreach loop
// ==================================================================


char[] array_of_characters;
int length;
string sentence = "A monkey stole a banana, climbed a tree and ate it.";
length = sentence.Length;
array_of_characters = sentence.ToCharArray(0, length);
Dictionary<char, int> dictionaryChar = new Dictionary<char, int>();
foreach (char c in array_of_characters)
{
    if (dictionaryChar.ContainsKey(c))
    {
        dictionaryChar[c]++;
    }
    else
    {
        dictionaryChar.Add(c, 1);
    }
}

foreach (KeyValuePair<char, int> pair in dictionaryChar)
    Console.WriteLine($"{pair.Key}:{pair.Value}");

// This is only here to stop the program before exiting
Console.ReadKey();