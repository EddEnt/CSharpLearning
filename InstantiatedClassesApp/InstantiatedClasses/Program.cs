

using InstantiatedClasses;

List<PersonModel> people = new List<PersonModel>();
List<AddressModel> addresses = new List<AddressModel>();

string firstName = string.Empty;
string lastName = string.Empty;
string street = string.Empty;
string city = string.Empty;
string country = string.Empty;
string postalCode = string.Empty;

do
{
    Console.Write("Enter your first name (or type 'exit' to stop): ");
    firstName = Console.ReadLine();
    Console.Write("Enter your last name: ");
    lastName = Console.ReadLine();
    Console.Write("Enter your street address: ");
    street = Console.ReadLine();
    Console.Write("Enter your city: ");
    city = Console.ReadLine();
    Console.Write("Enter your country: ");
    country = Console.ReadLine();
    Console.Write("Enter your postal code: ");
    postalCode = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
        AddressModel address = new AddressModel();
        address.Street = street;
        address.City = city;
        address.Country = country;
        address.PostalCode = postalCode;
        addresses.Add(address);
    }
} while (firstName.ToLower() != "exit");

//foreach (PersonModel person in people)
//{
//    ProcessPerson.GreetPerson(person);
//}

for (int i = 0; i < Math.Min(people.Count, addresses.Count); i++)
{
    ProcessPerson.GreetPerson(people[i]);
    ProcessAddress.ShowAddress(addresses[i]);
}

