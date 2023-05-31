class Room
{
    int length;

    // Full property definition
    public int Length
    {
        get
        {
            return length;
        }

        set
        {
            if (value > 10 && value < 20)
            {
                length = value;
            }
        }
    }

    // Auto-implemented property
    public int Width { get; set; }

    // Readonly property
    public double Area => Length * Width; 
}
