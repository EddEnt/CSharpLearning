using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class PartyManager
    {
        List<Person> people = new List<Person>();

        public void AddPersonAndPartySize()
        {
            Console.Write("Please enter your name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter the party size: ");
            if (int.TryParse(Console.ReadLine(), out int partySize))
            {
                people.Add(new Person { FirstName = firstName, PartySize = partySize });
                Console.WriteLine($"Person {firstName} was added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid party size. Please enter a valid number.");
            }
        }

        public void ViewAllPartiesAndSizes()
        {
            Console.WriteLine("--- All Parties and Party Sizes ---");
            Console.WriteLine();
            foreach (Person person in people)
            {
                Console.WriteLine($"-{person.FirstName}, Group Size: {person.PartySize}");
            }
        }

        public void ViewTotalNumberOfPeople()
        {
            int totalNumberOfPeople = 0;
            foreach(Person person in people)
            {
                totalNumberOfPeople += person.PartySize;
            }
            Console.WriteLine($"Total Number of People Attending:  {totalNumberOfPeople}");
        }

    }
}
