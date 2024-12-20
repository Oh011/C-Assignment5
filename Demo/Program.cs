
using System.ComponentModel;
using System.Xml.Linq;



namespace Demo
{

    enum WeekDays
    {

        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday



    }


    class Car
    {

        protected internal string name;
        internal int model;
        private protected int num;

    
    }

    class student
    {

        int age;



        public student() {

            Car x = new Car();

            Class1 z = new Class1();
        }

    }



    class Account
    {

        private int ID;
        private string name;
        private string password;


        // Automatic properties
        public int _GetID { get { return ID; } set { ID = value; } }

        public string getName { get { return name; } set { name = value; } }

        public string GetPassword { get { return password; } set { password = value; } }


        // Public getter, private setter
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }



        public Account(int id , string name , string pass )
        {

            this.ID = id;
            this.name = name;
            this.password = pass;
        }

        public override string ToString()
        {


            return ($" name : {this.name} , ID : {this.ID}");
        }

    }


    public interface ISYS
    {




        protected void fun2();
    }

        struct memeber
        {


            public int age;

     

            //protected int x; ->// not supported in stucts
        }


        [Flags]  // -> flag enum
        enum colors
        {


            none = 0, red = 1, blue = 2, green = 4, yellow = 8  // powers of 2 beacuse bitwise calculations without overlap
        }
        class Perimeter
        {

            // declaring enum 
            public enum shapes
            {
                circle,
                square
            }

            public void peri(int val, shapes s1)
            {

                // checking for shape to be circle
                if (s1 == 0)
                {

                    // Output the circumference
                    Console.WriteLine("Circumference of the circle is " +
                                                          2 * 3.14 * val);
                }

                else
                {

                    // else output the perimeter of the square
                    Console.WriteLine("Perimeter of the square is " +
                                                             4 * val);
                }
            }
        }

        public enum gender : byte
        {

            male, female
        }
        internal class Program
        {
            static void Main(string[] args)
            {


                #region Namespaces 

                //use the using directive to bring a namespace into scope

                // INside Namespace:
                // 1- class , struct , enum , Intreface , event , Delegates

                #endregion


                #region Enums

                // Enums is Value Type


                // Cast Enums to int

                WeekDays x = WeekDays.Sunday;

                WeekDays z = (WeekDays)3; // int to enum


                Console.WriteLine(x);

                WeekDays n = (WeekDays)Enum.Parse(typeof(WeekDays), "monday", true); // -> converts string t enum type

                //(WeekDays)Enum.Parse(typeof(WeekDays), "sunday",true) -> true -> case insensitve

                Console.WriteLine(Enum.IsDefined(typeof(WeekDays), "Sunday"));

                // -> Use Enum.IsDefined() to check if a value or name exists in the enum.


                //  Enum.GetNames(typeof(WeekDays)) -> gets as strings

                //  Enum.GetValues()  - > to retrieve an array of all enum members.

                // Enum.Parse(typeof(WeekDays), "monday",false) -> gives error if string not found in enum

                //Console.WriteLine(Enum.TryParse(typeof(Colors), "red", true ,out var result)); -> outputs true or false
                // -> Check if the  input matches any value in the Colors enum



                // flags enum used for ->File Permissions:
                //Read, Write, Execute, etc.


                //Use the bitwise OR operator (|) to combine flags

                colors p = colors.blue | colors.green;

                Console.WriteLine(p);

                //se the bitwise AND operator (&) to check if a specific flag is set.

                if ((p & colors.red) == colors.red)
                {

                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            //Use the bitwise AND NOT operator (& ~) to remove a flag.
            //--------------------------

            #endregion



            #region Access Modifiers


            // Allowed Acces Modifiers - >Top-level classes, structs, enums, and interfaces can only use public and internal
            // Internal -> full access to all modifiers


            // In struct :
            //allowed - > public, internal , protected
            //Structs do not support inheritance, so protected, protected internal,
            //and private protected are not valid for struct member


            // The default access modifier of attributes and methods in class , strct is private 
            // The default access modifier of Top level class , strct is internal

            //protected internal -> Accessible within the same assembly or in derived classes outside the assembly.


            //private protected :Accessible within the containing type and derived classes, but only
            //if they are in the same assembly.


            //What Interfaces Can Contain:
            //Methods(with no implementation).
            //Properties(with no implementation, just getters / setters).
            //Events(declarations).
            //Indexers(declarations).


            //interface members can only be public, and cannot be declared with protected, private, or
            //internal access modifiers.







            #endregion



            #region Encpsulation

            /*Getter and Setter:
            Properties consist of two key components:

            Getter (get): Retrieves the value of the property.
            Setter (set): Sets the value of the property
                         
             */


            Account A1 = new Account(1, "omar", "@312");

            A1.getName="ahmed";
            Console.WriteLine(A1.getName);
            Console.WriteLine(A1);




            #endregion




        }
    }
    }

