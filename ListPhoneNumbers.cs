public class ListPhoneBook:PhoneBook
{
    public void ListAll()
    {
        Console.WriteLine("Phone Book\n"+
        "**********************************************\n");
        foreach (var val in PhoneBook.PhoneBookList)
            Console.WriteLine("Name: {0}\n"+
                            "Surname: {1}\n"+
                            "Number: {2}\n"+
                            "\n",val.Name, val.Surname, val.Number);
    }
}