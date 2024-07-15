using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.OOP_3_Classes
{
    internal interface IConfigurable
    {
        //Signature for Property
       
        public string FullName { get; }

        // Signature for Method

        public void Configure();

        //Implmented Method

        //OverLoading
        public void Configure(string className)
        {
            Console.WriteLine($"Its Implmented From {className}");
        }

    }
}
