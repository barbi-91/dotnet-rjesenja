/*
 * Using classes and objects, create a simple application structure based on image in the project attachment (_004_exercise_example.png)
 * 
 */

using System.Collections.Generic;

namespace _004_exercise;

internal class Program
{
    static void Main(string[] args)
    {


        // Inside Person class create default constructor that will set all string value types to String.Empty, and DateTime value to DateTime.Now
        // Create object of the Person class and print defalut values
        Person person = new Person();
        Console.WriteLine("constructor - default");
        Console.WriteLine("First name: " + person.FirstName  + " \n Last name: " + person.LastName + " \n Date of Birth: " + person.DateOfBirth + "\n Tax payer ID: " + person.TaxPayerID);
        Console.WriteLine("*********");
        // Next, set an arbitrary values to your object and print them to console to see the difference in values
        person.FirstName = "Ana";
        person.LastName = "Programeric";
        person.DateOfBirth = new DateTime(2008, 12, 25);
        person.TaxPayerID = "34567";
        Console.WriteLine("constructor - assign values");
        Console.WriteLine("First name: " + person.FirstName + " \n Last name: " + person.LastName + " \n Date of Birth: " + person.DateOfBirth + "\n Tax payer ID: " + person.TaxPayerID);

        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
}