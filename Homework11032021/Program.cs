using System;

namespace Homework11032021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //Console.WriteLine("Hekim elave et");

            //string name = GetString("Name");
            //string surname = GetString("Surname");
            //string gender = GetString("Gender");

            //Human human = new Human(name, surname, gender);
            //human.ShowInfo();



            //Console.ReadKey();

            l1:

            Console.WriteLine("Soz daxil edin");
            string value = Console.ReadLine();

            if (value.Length < 3)
            {
                Console.WriteLine("3 herifden azdir");
                goto l1;
            }


        }

        public  static string GetString(string str)
        {
            Console.WriteLine(str);
            string value = Console.ReadLine();

            return value;
        }
    }
}
