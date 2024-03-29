﻿/*
 * Using If statement write a simple program to find eligibility for admission to professional studies
 */

int physics, chemistry, mathematics, total, totalMathPhys;
bool flag = true;


// The rules for your conditions can be found in the next sentences
Console.Write("The candidate can enroll in the study program only if he meets the following criteria: \n");
Console.Write("Points in Mathematics >=65\n");
Console.Write("and points in Physics >=55\n");
Console.Write("and points in Chemistry >=50\n");
Console.Write("and total for all three subjects >=180\n");
Console.Write("or total in Mathematics and Physics >=140\n");
Console.Write("-------------------------------------\n");

// Here we have basic logic to insert data
// (in this example input validation is not required, the user is expected to enter an integer values)
Console.Write("Enter the points obtained in Physics (0-100):");
physics = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the points obtained in Chemistry (0-100):");
chemistry = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the points obtained in Mathematics (0-100):");
mathematics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Total number of points in Mathematics, Physics and Chemistry: {0}\n", mathematics + physics + chemistry);
Console.Write("Total number of points in Mathematics and Physics: {0}\n", mathematics + physics);
Console.WriteLine();

// Insert your code logic below using combination of if, else if and else statements

total = mathematics + physics + chemistry;
totalMathPhys = mathematics + physics;

if (total >= 180 || totalMathPhys >= 140)
{
    if (mathematics >= 65 && mathematics <= 100)
    {
        Console.WriteLine($"Mathematics: Pass, {mathematics} points ");
    }
    else
    {
        Console.WriteLine("Exam Mathematics failure");
        flag = false;
    }
    if (physics >= 55 && physics <= 100)
    {
        Console.WriteLine($"Physics: Pass, {physics} points ");
    }
    else
    {
        Console.WriteLine("Exam Physics failure");
        flag = false;
    }
    if (chemistry >= 50 && chemistry <= 100)
    {
        Console.WriteLine($"Chemistry: Pass, {chemistry} points ");
    }
    else
    {
        Console.WriteLine("Exam Chemistry failure");
        flag = false;
    }
    if (flag == false)
    {
        Console.WriteLine($"If one of exam does not have critera points,regardless of the total {total}, this is not pass.");
        Console.WriteLine("Candidat do not have the following criteria:");
    }
    else
    {
        Console.WriteLine("Candidat have the following criteria:  The candidate can enroll in the study program");
    }
}
else
{
    Console.WriteLine("Candidat do not have the following criteria: ");
}






// This is only here to stop the program before exiting
Console.ReadKey();