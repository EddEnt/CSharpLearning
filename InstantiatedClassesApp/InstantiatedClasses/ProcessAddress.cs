using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses
{
    public class ProcessAddress
    {
        public static void ShowAddress(AddressModel address)
        {
            Console.WriteLine($"You live at {address.Street}, {address.City}, {address.Country} {address.PostalCode}");
        }
    }
}
