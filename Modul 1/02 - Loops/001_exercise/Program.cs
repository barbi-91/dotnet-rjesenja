/*
 * With the help of a While loop, create a simple program that will:
 *  - Ask for the input of two numbers and one operator (+,-,/,*) 
 *  - All inputs must be validated:
 *      - If validation fails, loop must restart
 *      - If validation is successful, program will preform calculation between number based on the selected operator
 *  - After every loop iteration ask if user wants to exit with simple (yes/no):
 *      - if user enters "yes" then loop ends
 *      - if user does not enter "yes", loop continues to iterate
 */

// Insert your code logic below using while loop
// ==================================================================

using System.Diagnostics.Metrics;
using System.Threading.Tasks;

Console.WriteLine("Please enter numbers and select operation to preform calculation.");
Console.WriteLine("If you wish to abort program, enter word \"end\".");


int operand = 0;
decimal total = 0, num1 = 0, num2 = 0;
string? word = null;
bool WordIsNotNumber = false, isValidIntInStrOperand = false, abortProgram = false;


Console.WriteLine();
while (word != "yes" && word != "end")
{
    //validate inputs -numbers
    for (int i = 1; i < 3; i++)
    {
        Console.WriteLine($"Enter {i} number: ");
        string? numStr = Console.ReadLine().ToLower();

        bool isValidDecimalInString = decimal.TryParse(numStr, out decimal result);

        // if 'end' is type
        if (numStr == "end")
        {
            WordIsNotNumber = true;
            isValidIntInStrOperand = false;
            abortProgram = true;
            break;
        }
        //validation fails
        if (isValidDecimalInString == false)
        {
            Console.WriteLine("That was not a number, please try again!");
            i--;
            continue;
        }
        //validation is successful
        if (isValidDecimalInString == true && i == 1)
        {
            num1 = result;
        }
        else if (isValidDecimalInString == true && i == 2)
        {
            num2 = result;
        }
    }

    while (WordIsNotNumber == false)
    {
        //validate input - operand
        Console.WriteLine("*******************");
        Console.WriteLine("Type number of which operand you want to use: \n 1: + \n 2: -,\n 3: *,\n 4: / ");
        string? operandStr = Console.ReadLine();
        isValidIntInStrOperand = int.TryParse(operandStr, out operand);

        // if end is type
        if (operandStr == "end")
        {
            isValidIntInStrOperand = false;
            abortProgram = true;
            break;
        }
        //validation fails
        if (isValidIntInStrOperand == false)
        {
            Console.WriteLine("That was not a number of operand, please try again!");
            WordIsNotNumber = false;
            continue;
        }
        else if (operand < 1 || operand > 4)
        {
            Console.WriteLine("Operand number is not between 1 and 4");
            WordIsNotNumber = false;
            continue;
        }
        else
        {
            WordIsNotNumber = true;
        }
    }
    //validation of operand is successful
    if (isValidIntInStrOperand == true)
    {
        switch (operand)
        {
            case 1:
                Console.WriteLine("Addition: ");
                total = num1 + num2;
                break;
            case 2:
                Console.WriteLine("Subtraction: ");
                total = num1 - num2;
                break;
            case 3:
                Console.WriteLine("Multiply: ");
                total = num1 * num2;
                break;
            case 4:
                Console.WriteLine("Dividing: ");
                total = num1 / num2;
                break;
            default:
                Console.WriteLine("Wrong number entered: ");
                break;
        }
        Console.WriteLine($"First number is: {num1}");
        Console.WriteLine($"Second number is: {num2}");
        Console.WriteLine("Result is: " + total);
    }
    Console.WriteLine("*******************");
    // if end is type
    if (abortProgram == false)
    {
        //After every loop iteration (calculation) ask if user wants to exit
        Console.WriteLine("Do you want to exit? type: 'yes', for another calculation press any key!");
        word = Console.ReadLine().ToLower();
        if (word == "yes")
        {
            break;
        }
        else
        {
            WordIsNotNumber = false;
            continue;
        }
    }
    else
    {
        Console.WriteLine("Program is aborted!");
        break;
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Calculations ended!");

// This is only here to stop the program before exiting
Console.ReadKey();