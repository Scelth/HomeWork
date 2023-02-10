using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public class Person
    {
        public string FullName { get; set; }
        public string Date { get; set; }
        public string Adress { get; set; }
        public string Skills { get; set; }

        public override string ToString()
        {
            return $"1.  Full Name: {FullName}\n" +
                $"\n    Year of birth: {Date}\n" +
                $"\n    Adress: {Adress}\n" +
                $"\n    Skills: {Skills}\n";
        }
    }
}
