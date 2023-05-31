class ABC<T>
{
    public void Print(T value)
    {
        Console.WriteLine($"Value is:{value}");
    }

    public void Display(T content)
    {
        Console.WriteLine($"Content provided:{content}");
    }

    public void Test()
    {
        ABC<int> abc = new();
        abc.Print(67);
    }
}
