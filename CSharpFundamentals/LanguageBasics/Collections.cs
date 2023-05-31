class CollectionLearner
{
    public void LearnListStackQueues()
    {
        byte[] numbers = { 2, 3, 4, 5 };
        
        // List
        List<byte> numberList = new List<byte> { 4, 5, 5, 6 };
        numberList.Add(34);
        numberList.Add(34);
        numberList.Add(34);
        numberList.Add(34);
        numberList.Remove(5);
        numberList.Reverse();

        List<string> names = new() { "Ramesh", "Ram", "Ganesh" };

        // Stack
        Stack<string> plates = new();
        plates.Push("Plate 1");
        plates.Push("Plate 2");
        plates.Push("Plate 3");
        plates.Push("Plate 4");
        plates.Push("Plate 5");
        plates.Push("Plate 6");

        plates.Pop(); //LIFO

        //Queue
        Queue<short> hospitalQueue = new();
        hospitalQueue.Enqueue(3);
        hospitalQueue.Enqueue(4);
        hospitalQueue.Enqueue(36);
        hospitalQueue.Enqueue(7);
        hospitalQueue.Enqueue(13);

        hospitalQueue.Dequeue(); //FIFO
    }
    
    public void LearnDictionary()
    {
        // Store names and age of 10 people
        Dictionary<string, byte> people = new();
        people.Add("Ramesh", 78);
        people.Add("Ram", 18);
        people.Add("Jiwan", 25);
        people.Add("Prabesh", 17);
        people.Add("Prabesh1", 17);

        foreach(var item in people)
        {
            Console.WriteLine($"{item.Key} is {item.Value} years old.");
        }        
    }
}




