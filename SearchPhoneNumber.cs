class SearchPhoneBook:PhoneBook
{
    public void DisplaySearchResult()
    {
        Console.WriteLine("Select the type you want to search.\n"+
                    "**********************************************\n"+
                    "To search by first or last name: (1)\n"+
                    "To search by phone number: (2)");
        switch(Console.ReadLine())
        {
            case "1":
                SearcByName();
            break;
            case "2":
                SearcByNumber();
            break;
            default:
                Console.WriteLine("Invalid operation");
            break;
        }   
    }
    private void SearcByName()
    {
        int index = FindPersonByName();
        if (index >= 0)
        {
            PersonInfo person = PhoneBookList[index];
            Console.WriteLine("Name: {0}\n"+
                            "Surname: {1}\n"+
                            "Number: {2}\n"+
                            "\n",person.Name, person.Surname, person.Number);
        }
        else
            Console.WriteLine("Not found.");        
    }

    private void SearcByNumber()
    {
        int index = FindPersonByNumber();
        if (index >= 0)
        {
            PersonInfo person = PhoneBookList[index];
            Console.WriteLine("Name: {0}\n"+
                            "Surname: {1}\n"+
                            "Number: {2}\n"+
                            "\n",person.Name, person.Surname, person.Number);
        }
        else
            Console.WriteLine("Not found.");   
    }
}