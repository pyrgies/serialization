using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("KrzysiuGej", "13.13.2013", Person.Gender.Female);

            Console.Write(person1);

            Console.ReadLine();
        }
    }
}
