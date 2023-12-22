using Single_Responsibility_Principle;

namespace Single_Responsibility_Principle_IdealCode;

class Database
{
    public string? State { get; set; }

    public void Connect()
    {
        //...
        Console.WriteLine("Connection was created to db.");
    }

    public void Disconnect()
    {
        //...
        Console.WriteLine("Connection was closed to db.");
    }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Name 1", Surname = "Surname 1" },
            new(){ Name = "Name 2", Surname = "Surname 2" },
            new(){ Name = "Name 3", Surname = "Surname 3" }
        };
    }
}