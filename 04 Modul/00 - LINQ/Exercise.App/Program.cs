using Exercise.Library;
using System.Text;

namespace Exercise.App;

internal class Program
{
    static void Main(string[] args)
    {
        

        // 1. Create object instance for "AssigmentClass"
        AssignmentClass assignmentClass= new AssignmentClass();

        // 2. Test your code by calling the methods from "AssigmentClass"
        assignmentClass.GetFirstParticipant();


        Console.ReadKey();
    }
}