using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.OOP_3_Classes
{
    internal class Child : Parente, IConfigurable
    {
        public string FristName { get; set; }
        public int Age { get; set; }
        public string FullName { 
            get
            {
                return string.Concat( FristName," ",ParenteFirstName, " ", ParenteLastName) ;

            } 
          
        }

        public void Configure()
        {
            Console.WriteLine("this Method Has been implmented By Child Class");
        }
        public Child():base()
        {
            
        }
        public Child(string Fname,string ParentFname,string PartentLname,int ParentAge, int Age) :base(ParentFname, PartentLname, ParentAge)
        {
            this.FristName = Fname ;
            this.Age = Age ;
        }

        public override string DisplayFullName()
        {
            return FullName;
        }

        public new string DisplayAge()
        {
            return Age.ToString() ;
        }


    }
}
