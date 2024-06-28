using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._06._03
{
    class Class1
    {
        public Class1(string cst_name, DateTime cst_birthday)
        {
            Name = cst_name;
            Birthday = cst_birthday;
        }
        public string Name { get; set; }
        
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            int age = DateTime.Today.Year - Birthday.Year;
            if (
                DateTime.Today.Month < Birthday.Month ||
                DateTime.Today.Month == Birthday.Month &&
                DateTime.Today.Day  < Birthday.Day
                )
            {
                age = age - 1;
            }
            return age;
        }
    }
}
