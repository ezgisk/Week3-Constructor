using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Constructor
{
    public class Bebek
    {
        // Fields
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public Bebek() //This constructor doesn't take any parameters
        {
            Birthday = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }
        public Bebek(string name, string surname) //This constructor takes name and surname as parameters
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = DateTime.Now;   

            Console.WriteLine("Ingaaaa");

        }
    }
}
