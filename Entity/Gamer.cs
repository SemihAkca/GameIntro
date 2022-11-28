using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gamer(int id,string firstName,string lastName,string nationalityId, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalityId = nationalityId;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}
