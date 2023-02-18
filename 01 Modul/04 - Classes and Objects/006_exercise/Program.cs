/*
 * Using classes and objects, create a simple application structure based on image in the project attachment (_006_exercise_example.png)
 * 
 */

namespace _006_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        // create two objects of the Person class and three objects of the Company class
        Person ana = new Person();
        Person david = new Person();

        Company vindija = new Company();
        Company carlsberg = new Company();
        Company saponia = new Company();

        Address address1 = new Address();
        address1.StreetAddress = "Omladinska 12";
        address1.City = "Beograd";
        address1.PostalCode = "101801";
        address1.Country = "Srbija";

        Address address2 = new Address();
        address2.StreetAddress = "Stanka Vraza 112";
        address2.City = "Varazdin";
        address2.PostalCode = "42000";
        address2.Country = "Croatia";

        Address address3 = new Address();
        address3.StreetAddress = "Medimurska 6";
        address3.City = "Varazdin";
        address3.PostalCode = "42000";
        address3.Country = "Croatia";

        Address address4 = new Address();
        address4.StreetAddress = "Danica ulica 3";
        address4.City = "Koprivnica";
        address4.PostalCode = "48000";
        address4.Country = "Croatia";

        Address address5 = new Address();
        address5.StreetAddress = "Matiije Gupca 2";
        address5.City = "Osijek";
        address5.PostalCode = "31000";
        address5.Country = "Croatia";

        // properly fill them with random data
        ana.FirstName = "Ana";
        ana.LastName = "Lahockic";
        ana.ResidentialAddress = address1;

        david.FirstName = "David";
        david.LastName = "Meltic";
        david.ResidentialAddress = address2;


        vindija.Name = "Vindija";
        vindija.Address = address3;

        carlsberg.Name = "Carlsberg";
        carlsberg.Address = address4;

        saponia.Name = "Saponia";
        saponia.Address = address5;

        //Print data
        Console.WriteLine($"{ana.FirstName} {ana.LastName}, {ana.ResidentialAddress.StreetAddress}, {ana.ResidentialAddress.PostalCode} {ana.ResidentialAddress.City}, {ana.ResidentialAddress.Country}");
        Console.WriteLine($"{david.FirstName} {david.LastName}, {david.ResidentialAddress.StreetAddress}, {david.ResidentialAddress.PostalCode} {david.ResidentialAddress.City}, {david.ResidentialAddress.Country}");
        Console.WriteLine($"{saponia.Name}, {saponia.Address.StreetAddress}, {saponia.Address.PostalCode} {saponia.Address.City}, {saponia.Address.Country}");
        Console.WriteLine($"{vindija.Name}, {vindija.Address.StreetAddress}, {vindija.Address.PostalCode} {vindija.Address.City}, {vindija.Address.Country}");
        Console.WriteLine($"{carlsberg.Name}, {carlsberg.Address.StreetAddress}, {carlsberg.Address.PostalCode} {carlsberg.Address.City}, {carlsberg.Address.Country}");


        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
}