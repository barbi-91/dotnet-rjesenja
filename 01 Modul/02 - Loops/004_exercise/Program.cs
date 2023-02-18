/*
 * Using a for loop print odd numbers that are greater than 1 and less than 20
 */

Console.WriteLine("Print odd numbers that are greater than 1 and less than 20:");
Console.WriteLine();
// Insert your code logic below using for loop
// ==================================================================
for (int i = 2; i < 20; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($"Odd numbers: { i } ");
    }
}

/*
 * Using a for loop print all numbers from the interval 1 to 300 that are divisible by 5
 */

Console.WriteLine("Print all numbers from the interval 1 to 300 that are divisible by 5:");
Console.WriteLine();
// Insert your code logic below using for loop
// ==================================================================
for (int i = 1; i <= 300; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine($"Odd numbers: { i } ");
    }
}


// This is only here to stop the program before exiting
Console.ReadKey();