

using GuestBook;

string inputUserChoice;

PartyManager partyManager = new PartyManager();

while (true)
{
    Console.WriteLine("--- Menu ---");
    Console.WriteLine("1. Add a New Party.");
    Console.WriteLine("2. View all Parties and Party Sizes.");
    Console.WriteLine("3. View Total Number of People Present.");
    Console.WriteLine("4. Exit");
    
    Console.Write("Select a Valid Option from the List Above: ");
    inputUserChoice = Console.ReadLine();
    Console.WriteLine();

    switch (inputUserChoice)
    {
        case "1":
            partyManager.AddPersonAndPartySize();
            break;
        case "2":
            partyManager.ViewAllPartiesAndSizes(); 
            break;
        case "3":
            partyManager.ViewTotalNumberOfPeople();
            break;
        case "4":
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid choice. Please make a valid selection.");
            break;
    }

}
