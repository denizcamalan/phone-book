class DeletePhoneNumber:PhoneBook
{
    public void DeletePerson()
    {
        int index = FindPersonByName();
        while(index < 0)
        {
                Console.WriteLine("There is not any person with this name. Please select operation."+
                "For cancel the delete oparation : (1)"+
                "For trying again: (2)");
                if (Console.ReadLine() == "2")
                    index = FindPersonByName();
                else
                    index = -1;
        }
        Console.WriteLine("Are you sure delete {0} {1} ?(y/n)",PhoneBookList[index].Name, PhoneBookList[index].Surname);
            if (Console.ReadLine() == "y")
                PhoneBookList.RemoveAt(index);
    }

}