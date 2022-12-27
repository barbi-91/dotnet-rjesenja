/*
 * Using classes and objects, create a simple application structure based on image in the project attachment (_005_exercise_example.png)
 * 
 */

namespace _005_exercise;

internal class Program
{
    static void Main(string[] args)
    {
        // create all of the necessary properties for the Person and Company classes
        // create an arbitrary number of objects and fill them with random data

        Person ana = new Person();
        ana.FirstName = "Ana";
        ana.LastName = "Programeric";
        ana.StreetAddress = "Dugoselska 15";
        ana.PostalCode = "42480";
        ana.Country = "Croatia";

        Person david = new Person();
        david.FirstName = "David";
        david.LastName = "Didajneric";
        david.StreetAddress = "Kolodvorska 35";
        david.PostalCode = "42000";
        david.Country = "Croatia";

        Company carlsberg = new Company();
        carlsberg.Name = "Carlsberg";
        carlsberg.StreetAddress = "Duga cesta 2";
        carlsberg.City = "Koprivnica";
        carlsberg.PostalCode = "48000";
        carlsberg.Country = "Croatia";

        Company vindija = new Company();
        vindija.Name = "Vindija";
        vindija.StreetAddress = "Maruliceva 4";
        vindija.City = "Varazdin";
        vindija.PostalCode = "42000";
        vindija.Country = "Croatia";
        


        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
}