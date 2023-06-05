// LINQ - Language INtegrated Query
// Used to query collections

class Crew
{
    public byte Age { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }
    public Gender Gender { get; set; }
}

class LINQ
{
    int[] numbers = { 3, 4, 5, 6, 7, 12, 67, 23, 45, 67, 78, 89, 90 };
    List<string> names = new() { "Ramesh Kharel", "Gagan Thapa", "Rabi Lamichhanne", "Prachanda", "Kp Ba" };
    List<Crew> employees = new()
    {
        new Crew { Name = "Emad", Age = 12, Gender = Gender.Male},
        new Crew { Name = "Ram", Age = 23, Gender = Gender.Male},
        new Crew { Name = "Rita", Age = 20, Gender = Gender.Female},
        new Crew { Name = "Ramesh", Age = 2, Gender = Gender.Male},
        new Crew { Name = "Emad1", Age = 12, Gender = Gender.Others},
        new Crew { Name = "Peter", Age = 50, Gender = Gender.Male},
        new Crew { Name = "Erin", Age = 40, Gender = Gender.Female},
    };

    public void LearnLINQ()
    {
        // Imperative
        // List<int> result = new();
        // foreach (var num in numbers)
        // {
        //     if(num > 50)
        //     {
        //         result.Add(num);
        //     }
        // }

        // Declarative

        // Get all numbers which are greater than 50 from "numbers"
        var numbersGreaterThan50 = numbers.Where(num => num > 50);

        // Get all numbers which are even or divisible by 4
        var evenNumbersDivBy4 = numbers.Where(x => x % 2 == 0 || x % 4 == 0);

        // Get squares of all numbers
        var squares = numbers.Select(x => x * x);

        // Get cubes of all numbers less than 10 and sort them in order

        // Method syntax
        var z = numbers.Where(x => x < 10).Select(y => y * y * y).Order();

        // Expression syntax
        var z1 = from x in numbers
                 where x < 10
                 orderby x
                 select x;


        // Skip first 4 items and get another 2 items
        var xx = numbers.Skip(4).Take(2);

        // Get all names which starts with letter g from 'names' collection
        var gagans = names.Where(x => x.StartsWith('G') || x.StartsWith('g'));

        // Get first names of all people in order
        var y = names.Select(name => name.Split()[0]).Order();

        // Get all female employees
        employees.Where(c => c.Gender == Gender.Female);

        // Get male crew names who are adults 
        var zz = from c in employees
                where c.Gender == Gender.Male && c.Age > 18
                select c.Name;


        foreach (var item in y)
        {
            Console.WriteLine(item);
        }
    }
}


