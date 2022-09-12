public class PhoneBook
{
    
    public static PersonInfo personInfo = new PersonInfo();

    public static List<PersonInfo> PhoneBookList = new List<PersonInfo>();

    public string CheckIsNull(string? s)
    {
        if (!string.IsNullOrEmpty(s))
            return s;
        else
            return "null string";
    }

    public int FindPersonByName()
    {
        Console.WriteLine("Please enter name");
        string Name = CheckIsNull(Console.ReadLine());
        Console.WriteLine("Please Enter Surname");
        string Surname = CheckIsNull(Console.ReadLine());

        foreach (var person in PhoneBookList)
            if (person.Name == Name && person.Surname == Surname)   
                return PhoneBookList.IndexOf(person);
        return -1;
    }

    public int FindPersonByNumber()
    {
        Console.WriteLine("Please enter number");
        int number = int.Parse(CheckIsNull(Console.ReadLine()));

        foreach (var person in PhoneBookList)
            if (person.Number == number)   
                return PhoneBookList.IndexOf(person);
        return -1;
    }
    
    public void Applicaiton()
    {
    
        PersonInfo person1 = new PersonInfo("Deniz", "Çamalan", 4442727);
        PersonInfo person2 = new PersonInfo("Ayşe", "Onar", 4536543);
        PersonInfo person3 = new PersonInfo("Ege", "Soyarar", 6748832);
        PersonInfo person4 = new PersonInfo("Ceran", "Aydin", 3836441);
        PersonInfo person5 = new PersonInfo("Özgür", "Çamalan", 3452345);

        SavePhoneNumber savePhoneNumber = new SavePhoneNumber();
        DeletePhoneNumber deletePhoneNumber = new DeletePhoneNumber();
        ListPhoneBook listPhoneBook = new ListPhoneBook();
        UpdatePersonInfo updatePersonInfo = new UpdatePersonInfo();
        SearchPhoneBook searchPhoneBook = new SearchPhoneBook();

        savePhoneNumber.AddPhoneBook(person1);
        savePhoneNumber.AddPhoneBook(person2);
        savePhoneNumber.AddPhoneBook(person3);
        savePhoneNumber.AddPhoneBook(person4);
        savePhoneNumber.AddPhoneBook(person5); 


        Console.WriteLine("Please select operation you want :)\n"+
        "*******************************************\n"+
        "(1) Save New Number\n"+
        "(2) Delete Existing Number\n"+
        "(3) Update Existing Number\n"+
        "(4) List PhoneBook\n"+
        "(5) Search PhoneBook\n"+ 
        "(6) EXIT\n"
        );

        while(int.TryParse(Console.ReadLine(), out int selected) && selected != 6)
        {
            if (selected == 1)
                savePhoneNumber.AddPhoneBook(savePhoneNumber.CreatePersonInfo());
            else if (selected == 2)
                deletePhoneNumber.DeletePerson();
            else if (selected == 3)
                updatePersonInfo.UpdatePerson();
            else if (selected == 4)
                listPhoneBook.ListAll();
            else if (selected == 5)
                searchPhoneBook.DisplaySearchResult();
            else
            {
                Console.WriteLine("invalid Operation");
            }
            Console.WriteLine("Please select another operation :)" );
        }
    }
}


public struct PersonInfo
{
  private string name;
  private string surname;

  private int number;

  public PersonInfo(string name, string surname, int number) : this()
  {
    this.name = name;
    this.surname = surname;
    this.number = number;
  }
   public PersonInfo(string name, string surname) : this()
  {
    this.name = name;
    this.surname = surname;
  }

  public string Name { get => name; set => name = value; }
  public string Surname { get => surname; set => surname = value; }
  public int Number { get => number; set => number = value; }

}