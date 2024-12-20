using System.ComponentModel.DataAnnotations;

namespace C_Assignment5
{


    #region Q1 enum
    enum WeekDays
    {

        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    #endregion



    #region Q2 and Q3 struct

    struct Person
    {


        private int age;
        private string Name;




        public int _Age
        {
            get { return age; }
            set { age = value; }
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }




        public Person(int age, string name)
        {
            this.age = age;
            this.Name = name;
        }


        public Person()
        {

            this.age = 0;
            this.Name = "";


        }




        public static void GetOldest(Person p1 , Person p2 , Person p3)
        {



            if (p1._Age >= p2._Age && p1._Age>=p3._Age)
            {

               Console.WriteLine( p1.ToString());
            }

            else if(p2._Age >= p1._Age && p2._Age >= p3._Age)
            {


                Console.WriteLine(p2.ToString());
            }

            else
            {

                Console.WriteLine(p3.ToString());
            }
          


        }





        public override string ToString()
        {


            return ($" Name is : {this.Name} , Age : {this.age}");
        }


    }

    #endregion



    #region Q3 enum


    enum Season
    {
        Spring, Summer, Autumn, winter
    }

    public enum Months
    {

        March = 1,
        April = 2,
        May = 3,
        June = 4,
        July = 5,
        August = 6,
        September = 7,
        October = 8,
        November = 9,
        December = 10,
        January = 11,
        February = 12,
    }

    #endregion


    #region Q4 enum

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1, Write = 2, Delete = 4, Execute = 8

    }
    #endregion



    #region Q5 enum
    enum Colors
    {

        Red, Blue, Green
    }

    #endregion


    #region Q6 struct



    struct Point
    {


       public double X { get; set; }
       public double Y { get; set; }



        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

       public Point()
        {

            this.X = 0;
            this.Y = 0;


        }

        public static double CalcualateDistance(Point p1, Point p2)
        {


            return (Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2)));
        }

    }



    #endregion










    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays))) // strings -> sunady
            //{
            //    Console.WriteLine(day);
            //}

            #endregion


            //-------------------------------------


            #region Q2


            //Person []arr = new Person[3];

            //arr[0] = new Person(20, "omar");
            //arr[1] = new Person(19, "Ahmed");
            //arr[2] = new Person(18, "Mohamed");



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].ToString());
            //}

            #endregion


            //-----------------------------------


            #region Q3


            //Console.WriteLine("Enter Season Name :");

            //string SeasonName = Console.ReadLine();


            //if (Enum.TryParse(typeof(Season), SeasonName, true, out object Valid))
            //{


            //    Season S = (Season)Enum.Parse(typeof(Season),SeasonName,true);


            //    if ((int)S == 0)
            //    {

            //        for (int i =1; i <= 3; ++i)
            //        {
            //            Console.Write((Months)i+" ");
            //        }

            //    }

            //    else if ((int)S == 1)
            //    {

            //        for (int i =4; i <=6; ++i)
            //        {
            //            Console.Write((Months)i+" ");
            //        }

            //    }


            //    else if ((int)S == 2)
            //    {

            //        for (int i =7; i <= 9; ++i)
            //        {
            //            Console.Write((Months)i+" ");
            //        }

            //    }


            //    else
            //    {
            //        for (int i =10; i <= 12; ++i)
            //        {
            //            Console.Write((Months)i+" ");
            //        }


            //    }


            #endregion



            //----------------------------------------------------------
            #region Q4


            //Permissions P= Permissions.Read | Permissions.Write;


            ////add Permissions
            //P|= Permissions.Delete;


            //// check If permissions Exist


            //if ((P & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine(" exists");
            //}

            //else
            //{
            //    Console.WriteLine(" does not exists");
            //}


            //// Remove permission

            //P&=~ Permissions.Write;


            #endregion


            //-----------------------------------------------

            #region Q5

            //Console.WriteLine("Enter a Color :");

            //string color=Console.ReadLine();





            //if (Enum.TryParse(typeof(Colors),color , true , out object Valid))
            //{

            //    Console.WriteLine($" {color} is a Primary color");

            //}

            //else
            //{
            //    Console.WriteLine($" {color} is not a Primary color");

            //}

            //-------------------------------
            #endregion


            //-----------------------------------------------

            #region Q6


            //Point p1, p2;
            //p1 = new Point();
            //p2 = new Point();


            //Console.WriteLine("Enter X for Point 1 :");
            //p1.X=double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y for Point 1 :");
            //p1.Y=double.Parse(Console.ReadLine());



            //Console.WriteLine("Enter X for Point 2 :");
            //p2.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y for Point 2 :");
            //p2.Y = double.Parse(Console.ReadLine());



            //Console.WriteLine($" Distance is {Point.CalcualateDistance(p1, p2)}");



            #endregion


            //--------------------------


            #region Q7

            //Person p1=new Person(12,"omar");
            //Person p2=new Person();
            //Person p3=new Person();


            //Console.WriteLine(" Enter Name for person 1");
            //p1._Name = Console.ReadLine();

            //Console.WriteLine("Enter Age of Person 1");
            //p1._Age=int.Parse(Console.ReadLine());



            //Console.WriteLine(" Enter Name for person 2");
            //p2._Name = Console.ReadLine();


            //Console.WriteLine("Enter Age of Person 2");
            //p2._Age = int.Parse(Console.ReadLine());



            //Console.WriteLine(" Enter Name for person 3");
            //p3._Name = Console.ReadLine();



            //Console.WriteLine("Enter Age of Person 3");
            //p3._Age = int.Parse(Console.ReadLine());



            //Person.GetOldest(p1, p2, p3);





            #endregion
        }
    }
    }
