public class SavePhoneNumber:PhoneBook
{
    public PersonInfo CreatePersonInfo(){
        Console.WriteLine("Please Enter Name");
        personInfo.Name = CheckIsNull(Console.ReadLine());
        Console.WriteLine("Please Enter Surname");
        personInfo.Surname = CheckIsNull(Console.ReadLine());
        Console.WriteLine("Please Enter Number");
        personInfo.Number = int.Parse(CheckIsNull(Console.ReadLine()));

        return personInfo;
    }

    public void AddPhoneBook(PersonInfo personInfo)
    {   
        PhoneBookList.Add(personInfo);
    }
    
}