using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo1
{
    class InputOutput
    {
        public static void GetName()
        {
            string FirstName, LastName;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", FirstName, LastName);
            Console.WriteLine("Your username will be " + FirstName.ToLower() + LastName.ToLower());
            //Should also include C#6 "Hello {FirstName} {LastName}" syntax in lesson
        }
    }
}
