namespace BasicConstructs;
class Loops
{
    public void LearnLoops()
    {
        // for
        for (byte counter = 1; counter <= 40; counter++)
        {
            Console.WriteLine($"{counter}: Nepal is beautiful country!");

            if (counter == 15)
                break;
        }

        //Print "Hello" until loop variable value reaches 15
        // Note: Loop variable starts from 1 and ends at 40

        // while
        //Print "Hello" until user says stop

        string userInput = "";
        while (userInput != "stop")
        {
            Console.WriteLine("Hello there!!");
            userInput = Console.ReadLine();
        }

        // foreach
        string[] names = { "ram", "krishna", "John", "Peter" };
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        // Create array to hold names of 10 people, 
        // print all of them in console in uppercase
        string[] nameList = { "ram", "krishna", "John", "Peter" };
        foreach(string name in nameList)
        {
            Console.WriteLine(name.ToUpper());
        }

        // You have a string value: string text = "Nepal is landlocked country.":
        // Q1: Write a program to print all words in 'text' in new line.
        // Q2: In each line, display result like:
        //      Nepal: 5 characters
        //      is: 2 characters
        //      landlocked: 10 characters
        //      country.: 8 characters
        // Note: you can't use escape sequences
        // Hint: use Split helper method

        string text = "Nepal is landlocked country.";
        
        
    }
}