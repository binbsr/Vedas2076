namespace BasicConstructs;
class Selection
{
    public void LearnConditionals()
    {
        // Check if student got distinction, first division, second division or failed.
        Console.Write("Enter student marks obtained: ");
        string totalMarksText = Console.ReadLine();
        float totalMarks = float.Parse(totalMarksText);
        float fullMarks = 800.0f;

        float percentage = totalMarks / fullMarks * 100;
        if (percentage >= 80)
        {
            Console.WriteLine($"Student got distinction ({percentage}%)!");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine($"Student got first division ({percentage}%)!");
        }
        else if (percentage >= 40)
        {
            Console.WriteLine($"Student got second division ({percentage}%)!");
        }
        else
        {
            Console.WriteLine($"Student failed ({percentage}%)!");
        }
    }

    public void LearnConditionalsWithSwitch()
    {
        // Check if student got distinction, first division, second division or failed.
        Console.Write("Enter student marks obtained: ");
        string totalMarksText = Console.ReadLine();
        float totalMarks = float.Parse(totalMarksText);
        float fullMarks = 800.0f;

        float percentage = totalMarks / fullMarks * 100;
        switch (percentage)
        {
            case >= 80:
                Console.WriteLine($"Student got distinction ({percentage}%)!");
                break;
            case >= 60:
                Console.WriteLine($"Student got first division ({percentage}%)!");
                break;
            case >= 40:
                Console.WriteLine($"Student got second division ({percentage}%)!");
                break;
            default:
                Console.WriteLine($"Student failed ({percentage}%)!");
                break;
        }
    }
}
