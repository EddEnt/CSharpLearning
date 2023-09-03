using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class Party
    {
        public string PartyName { get; set; }
        public List<Person> People { get; set; } = new List<Person>();

    }
}
