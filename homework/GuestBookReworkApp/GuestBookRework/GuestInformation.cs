using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary;
using GuestBookLibrary.Models;

namespace GuestBookRework
{
    public class GuestInformation
    {

        private static List<GuestModel> guests = new List<GuestModel>();

        public static string GetInformationFromConsole(string message)
        {
            string output = string.Empty;

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        public static void GetGuestInformation()
        {
            string moreGuestsToBeEntered = string.Empty;

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInformationFromConsole("Guest First Name: ");
                guest.LastName = GetInformationFromConsole("Guest Last Name: ");
                guest.MessageToHost = GetInformationFromConsole("Guest message for host: ");
                moreGuestsToBeEntered = GetInformationFromConsole("Do more guests need to be entered? (yes/no):  ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsToBeEntered.ToLower() == "yes");
        }

        public static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

    }
}
