using System.Diagnostics.CodeAnalysis;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            //ARRAY

            //First method of writing array
            string[] cars = { "John", "Peter", "Ben", "Kelly" };

            cars[3] = "Daniel";

            Console.WriteLine(cars[3]);
            Console.WriteLine("");

            //Second method
            string[] DaysOfWeek = new string[3] { "moday", "tuesday", "wenesday"};

            Console.WriteLine(DaysOfWeek[0]);
            Console.WriteLine(DaysOfWeek[1]);
            Console.WriteLine(DaysOfWeek[2]);
            Console.WriteLine("");


            //Looping through an array.
            string[] names;

            names = new string[]{ "Daniel", "Kelly", "Ben", "Hope" };

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("");


            //Foreach loop
            string[] phns = new string[3] { "iphone1", "iphone2", "iphone3"};
            foreach (string item in phns)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            //Sorting an Array
            string[] Names = new string[3] { "Zad", "Yoke", "Ali" };

            Array.Sort(Names);

            foreach (string item in Names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            //Accessing Math method in CSharp.
            int[] Num = new int[5] { 2, 5, 90, 2, 45 };

            Console.WriteLine(Num.Max());
            Console.WriteLine(Num.Min());
            Console.WriteLine(Num.Sum());
            Console.WriteLine(Num.Average());
            Console.WriteLine("");

            //Multi-dimensional Array
            int[,] TableArries = { {1,4,2,6,7 },{ 3,4,9,1,7 } };
            Console.WriteLine(TableArries[0,4]);
            Console.WriteLine("");

            //Loop through a Multi-dimensional Array
            foreach (int i in TableArries)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            //string[] pho = { "tecno", "samsung", "iphone" };


            //When using for Loop to get for Multi-dimensional Array you have to make
            //Use of the .Getlength() Method instead of .Length()
            //And because it's Multi-dimensional we make use of one for loop inside another for Loop
            //OR
            for(int i = 0; i < TableArries.GetLength(0); i++)
            {
                for(int j = 0; j < TableArries.GetLength(1); j++)
                {
                    Console.WriteLine(TableArries[i,j]);
                }
                
            }
            Console.WriteLine("");

        }
    }
}

