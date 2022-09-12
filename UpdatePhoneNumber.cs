class UpdatePersonInfo:PhoneBook
{
     public void UpdatePerson()
    {
        int index = FindPersonByName();
        while(index < 0)
        {
                Console.WriteLine("There isn't any person with this name. Please select operation."+
                "For cancel the update oparation : (1)"+
                "For trying again: (2)");
                if (Console.ReadLine() == "2")
                    index = FindPersonByName();
                else
                    index = -1;
        }
        Console.WriteLine("Are you sure update {0} {1} ?(y/n)",PhoneBookList[index].Name, PhoneBookList[index].Surname);
            if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Please enter updated name");
                    string name = CheckIsNull(Console.ReadLine());
                    Console.WriteLine("Please enter updated surname");
                    string surname = CheckIsNull(Console.ReadLine());
                    PhoneBookList[index] = new PersonInfo(name,surname,PhoneBookList[index].Number);
                }

    }
}