using OOP_3.OOP_3_Classes;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Polymorphism
            #region OverLoading & Overriding 

            IConfigurable configurable = new Child();

            configurable.Configure("Called Overloading Method By making ref of interface => object of child that implments the interface");


            Child child = new Child("Michael", "Raafat", "Dawood", 66, 26);

            Console.WriteLine(child.DisplayFullName());
            Console.WriteLine(child.DisplayAge());

            Parente parente = new Parente("Dawood", "Nabieh", 66);
            Console.WriteLine(parente.DisplayFullName());
            Console.WriteLine(parente.DisplayAge());



            #endregion

            #region Binding

            /// ref of parent => object of child
            Parente bind_Parent = new Child("WOOOOO", "WOOOOO", "Mpppppp", 25, 63);
            bind_Parent.ParenteLastName = "WOOOOO";
            bind_Parent.ParenteFirstName = "Mpppppp";

            bind_Parent.DisplayAge();///25  the last override which is the child (Dynamic Binding) late binding
            bind_Parent.DisplayFullName();////Mpppppp WOOOOO 63  the base method (Static Binding) early binding



            //ref of child => object of parent
            //casting Not Binding
            Child Bchild = (Child)new Parente();
            Bchild.DisplayFullName();
            Bchild.DisplayAge();
            #endregion
        }

        #region Interface
        internal class Childs : IConfigurable
        {
            public string FullName { get { return "CHilds Prop"; } }

            public void Configure()
            {
                Console.WriteLine(this.FullName);
            }
        }


        #endregion

    }
}

