using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11032021
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private string _gender;
        public string Gender 
        {
            get 
            {
                return _gender;
            }
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    if (value.ToLower() == "male" || value.ToLower() == "female")
                    {
                        _gender = value;
                    }
                    else
                    {
                        throw new InvalidGenderException("No such a gender type");
                    }
                }
            } 
        }

        public Human(string name, string surname, string gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name},{Surname},{Gender}");
        }
    }
}
