public class Methods
{
    // Simplest possible: Returns nothing, takes no parameters
    public void PrintDetails()
    {
        Console.WriteLine("I am from PrintDetails method.");
    }

    // Returns nothing, takes some parameters
    public void PrintDetails(string name)
    {
        Console.WriteLine(name);
    }

    // Returns something, takes some parameters
    public double Average(double a, double b)
    {
        return a + b / 2;
    }

    // Variable number of arguments
    public double Average(params double[] numbers)
    {
        double av = 0, sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        av = sum / numbers.Length;

        return av;
    }

    public (int, int) FindMinMax(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach(var num in numbers)
        {
            if (min > num)
                min = num;
            if (max < num)
                max = num;
        }

        return (min, max);      // Tuple
    }

    // Arrow funtions
    public double Average(double a, double b, double c) => a + b + c / 3;
    
}