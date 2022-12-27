using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_exercise
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TaxPayerID { get; set; }

        public Person()
        {
            FirstName = String.Empty;
            LastName = String.Empty;    
            DateOfBirth = DateTime.Now;
            TaxPayerID = String.Empty;
        }
    }
}
