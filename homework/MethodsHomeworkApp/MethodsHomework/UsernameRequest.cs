using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    internal class UsernameRequest
    {
        public static string GetFullName() 
        {
            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();

            return $"{firstName} {lastName}";

        }
    }
}
