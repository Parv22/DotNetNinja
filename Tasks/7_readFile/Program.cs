using System;

public class Tester{

    public static void Main(){
        string FilePath = @"files/sample-text-file.txt";

        Console.WriteLine("Reading file...");

        string Text = File.ReadAllText(FilePath);

        Console.WriteLine(Text);

        Console.WriteLine("Coverting text to lower case.");

        string TextInLowerCase = Text.ToLower();

        Console.WriteLine("Writing Text in new text file");

        string WriteFilePath = @"files/sample-text-file-2.txt";

        File.WriteAllText(WriteFilePath,TextInLowerCase);
    }
}