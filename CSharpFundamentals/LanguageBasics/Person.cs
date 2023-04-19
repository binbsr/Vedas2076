class Person
{
    // Default parameterless constructor
    public Person()
    {        
    }

    // Parameterized constructor
    public Person(string n, byte a)
    {        
        name = n;
        age = a;
    }

    // data: Instance members vs static members 
    public byte age = 90;
    public string name;
    public string contact;
    public float weightInKg;
    public char gender;
    public static string scientificName = "Homo Sepians";

    // functionalities
    public void PrintDetails()
    {
        Console.WriteLine($"Details on {name}");
    }
}
