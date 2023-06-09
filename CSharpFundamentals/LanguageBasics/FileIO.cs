class FDHandling
{
    public void LearnFileIO()
    {
        var folderPath = @"D:\Apps\Vedas2076-git\Vedas2076\CSharpFundamentals\LanguageBasics\FileIO";
        var filePath = $@"{folderPath}\file1.txt";

        // Create 20 files with names 1.txt, 2.txt and so on...

        // // create files from A to Z with names A.txt, B.txt, C.txt... etc.
        // for (char f = 'A'; f <= 'Z'; f++)
        // {
        //     var fPath = folderPath + $"\\{f}.txt";
        //     File.WriteAllText(fPath, $"Hello there, I am {f}");
        // }

        // Console.WriteLine("Do you want to delete all these test files? y/n");
        // var confrim = Console.ReadLine();

        // if (confrim != "y")
        //     return;

        // for (char f = 'A'; f <= 'Z'; f++)
        // {
        //     var fPath = folderPath + $"\\{f}.txt";
        //     File.Delete(fPath);
        // }

        // Get all meta info for file "DataTypes.cs" like size, created Date etc.
        FileInfo fi = new FileInfo(@"D:\Apps\Vedas2076-git\Vedas2076\CSharpFundamentals\LanguageBasics\DataTypes.cs");
        Console.WriteLine($"Created: {fi.CreationTime} \n Modified: {fi.LastWriteTime} \n Size: {fi.Length} bytes");
    }

    public void LearnDirectories()
    {
        var folderPath = @"D:\Apps\Vedas2076-git\Vedas2076\CSharpFundamentals\LanguageBasics\FileIO";
        Directory.CreateDirectory(folderPath + "\\ABC");
    }    
}
