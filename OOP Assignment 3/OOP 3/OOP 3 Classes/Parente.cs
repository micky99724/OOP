using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.OOP_3_Classes
{
    internal class Parente
    {
        public string ParenteFirstName { get; set; }

        public string ParenteLastName { get; set; }

        private int ParenteAge{ get; set; }

        public Parente()
        {
            
        }
        public Parente(string FirstName, string LastName, int Age)
        {
            ParenteFirstName = FirstName;
            ParenteLastName = LastName;
            ParenteAge = Age;
        }

        public virtual string DisplayFullName() 
        { 
            return string.Concat("First Name :",ParenteFirstName," Second Name",ParenteLastName," Age:",ParenteAge);
        }

        public virtual string DisplayAge() 
        {
            return ParenteAge.ToString(); 
        }
    }
}
