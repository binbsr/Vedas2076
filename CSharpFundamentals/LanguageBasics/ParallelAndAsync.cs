// Parallel Programming - Executing our code in parallel with in individual CPU cores
// Asynchronous Programming - Executing something (long running task) without blocking others

// Multithreading
// TPL - Task Parallel Library

using System.Diagnostics;

class ParallelAndAsync
{
    public void LearnParallel()
    {
        int[] numbers = { 2, 4, 5, 5, 6, 7, 7, 8, 5, 4, 3, 45, 6 };
        
        Stopwatch sw = Stopwatch.StartNew();
        // Calculate square root of all numbers
        Console.WriteLine("Sequential:");
        foreach (var num in numbers)
        {
            var sr = CalculateSR(num);
            Console.WriteLine($"Squareroot of {num} is {sr}");
        }
        Console.WriteLine($"Took {sw.ElapsedMilliseconds} ms.");


        sw.Restart();
        Console.WriteLine("Parallel:");
        Parallel.ForEach(numbers, (num) => {
            var sr = CalculateSR(num);
            Console.WriteLine($"Squareroot of {num} is {sr}");
        });

        Console.WriteLine($"Took {sw.ElapsedMilliseconds} ms.");
    }

    double CalculateSR(int num)
    {
        var sr = Math.Sqrt(num);
        Thread.Sleep(1000);
        return sr;
    }

    public async Task DoWork()
    {
        await DoTask1();
        await DoTask2();
        await DoTask3();
    }

    async Task<int> DoTask1() => await Task.FromResult(23);

    async Task DoTask2() => await Task.Delay(1000);

    async Task DoTask3() => await Task.CompletedTask;
}

