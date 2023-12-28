using PropertyTypesHomework.Models;
//Create a class that has properties for an address, but the FullAddress property is read only


AddressModel address = new AddressModel("802 Boston Way", "Chicago", "Illinois", "USA", "1A2 B3C");

Console.WriteLine(address.FullAddress); //Full Address is read only, all other properties are private get, public set

