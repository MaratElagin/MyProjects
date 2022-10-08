using System;
using CBF;

public class Program
{
    static void Main(string[] args)
    {
        string text = "";
        var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
        var filePath = Path.Combine(dir.Parent.Parent.Parent.ToString(), "Chapter11.txt");
        
        using (var sr = new StreamReader(filePath))
            text = sr.ReadToEnd();
        
        char[] separators = {' ', '\n', ',', '.', '-', ':', ';', '?', '!', ')', '('};
        string[] words = text
            .Split(separators,
                StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .ToArray();

        var cbf = new Cbf(words.Length, 0.1);
        foreach (var word in words)
            cbf.Add(word);
        
        
        //Console.WriteLine($"really {cbf.FindString("really")}");
        
        //Console.WriteLine($"realy {cbf.FindString("realy")}");
        
        // cbf.Remove("really");
        // Console.WriteLine($"really {cbf.FindString("really")}");

        Console.WriteLine(cbf.FindString("Marat"));
        cbf.Add("Marat");
        Console.WriteLine(cbf.FindString("Marat"));
    }
}