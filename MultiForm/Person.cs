using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Image { get; set; }           
        public DateTime DataOfBirth { get; set; }

        public string Number  { get; set; }

        public string Email { get; set; }
        public Gender Gender { get; set; }

        public bool Favortie { get; set; }

        public override string ToString()
        {
            return $"{Name.ToString().PadRight(15)} {Surname.ToString().PadRight(15)}";
        }
    }
}
