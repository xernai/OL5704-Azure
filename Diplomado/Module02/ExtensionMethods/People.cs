using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class People
    {
        // Notacion hungara
        private string name;

        //public string Name { get; set; }

        public string Name
        {
            get { return name; }

            set
            {
                name = value;
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }

        //public void Trabajar()
        //{
        //    Console.WriteLine(Name + " es un trabajador.");
        //}
    }
}
