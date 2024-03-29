﻿/*
 * Using Switch statement write a simple menu-driven program to perform a calculation of two numbers.
 */
using System;

int first_number, second_number, select_option, total;

// Here we have basic logic to insert data
// (in this example input validation is not required, the user is expected to enter an integer values)
Console.Write("Enter the first number: ");
first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
second_number = Convert.ToInt32(Console.ReadLine());

Console.Write("\nSelect a calculation operation:\n");
Console.Write("1-Addition.\n2-Deduction.\n3-Multiplication.\n4-Division.\n5-Exit the program.\n");
Console.Write("\nSelect one option by number: ");
select_option = Convert.ToInt32(Console.ReadLine());

// Insert your code logic below using switch expression with case, don't forget about break and default keywords
switch (select_option)
{
    case 1:
        Console.WriteLine("Addition");
        total = first_number + second_number;
        Console.WriteLine($"Total:  { total}");
        break;
    case 2:
        Console.WriteLine("Deduction");
        total = first_number - second_number;
        Console.WriteLine($"Total:  { total}");
        break;
    case 3:
        Console.WriteLine("Multiplication");
        total = first_number * second_number;
        Console.WriteLine($"Total:  { total}");
        break;
    case 4:
        Console.WriteLine("Division");
        total = first_number / second_number;
        Console.WriteLine($"Total:  { total}");
        break;
    default:
        Console.WriteLine("Exit the program");
        break;
}
// This is only here to stop the program before exiting
Console.ReadKey();