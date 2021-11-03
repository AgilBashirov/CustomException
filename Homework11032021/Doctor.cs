using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11032021
{
    class Doctor: Human
    {
        public int No { get; set; }
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public Doctor(string name,string surname, string gender,int no, string speciality, int experience):base(name, surname, gender)
        {
            No = no;
            Speciality = speciality;
            Experience = experience;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"No: {No}, Speciality: {Speciality}, Experience: {Experience}");
               
        }
    }
}
