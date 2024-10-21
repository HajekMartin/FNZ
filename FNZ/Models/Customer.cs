using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNZ.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public Customer(string name, DateTime dateOfBirth, Gender gender)
        {
            if (dateOfBirth > DateTime.Now)
            {
                throw new Exception("Birthday_error");
            }
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public int Age()
        {
            var actualTime = new DateTime(DateOfBirth.Year, DateTime.Now.Month, DateTime.Now.Day);

            if (actualTime.Date >= DateOfBirth.Date)
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }

            return DateTime.Now.Year - DateOfBirth.Year + 1;
        }
    }
}
