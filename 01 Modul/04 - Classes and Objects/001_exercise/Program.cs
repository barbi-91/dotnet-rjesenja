/*
 * Using classes and objects, create a simple application structure based on image in the project attachment (_001_exercise_example.png)
 * 
 */

namespace _001_exercise;

internal class Program
{
    static void Main(string[] args)
    {
        // Create three objects of the User class and fill them with arbitrary data

        //user 1: ana
        User ana = new User();
        ana.FirstName = "Ana";
        ana.SecondName = "Klaic";
        ana.Age = 23;
        ana.Address = "Dugogradska 33";
        ana.Phone = 098234645;

        Console.WriteLine("Firt and Last Name: " + ana.FirstName +" "+ ana.SecondName + ", Age: " + ana.Age + ", Address: " + ana.Address + ", Phone: " + ana.Phone);

        //user 2: michael
        User michael = new User();
        michael.FirstName = "Michael";
        michael.SecondName = "Mihic";
        michael.Age = 27;
        michael.Address = "Kolodvorska 2";
        michael.Phone = 099234567;

        Console.WriteLine($"Firt and Last Name: {michael.FirstName} {michael.SecondName}, Age: {michael.Age}, Address: {michael.Address}, Phone: {michael.Phone}");


        //user 3: david
        User david = new User();
        david.FirstName = "David";
        david.SecondName = "Darvicic";
        david.Age = 24;
        david.Address = "Cesta 15";
        david.Phone = 091562347;

        Console.WriteLine("Firt and Last Name: {0} {1}, Age: {2}, Address: {3}, Phone: {4}", david.FirstName, david.SecondName, david.Age, david.Address, david.Phone);


        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
}