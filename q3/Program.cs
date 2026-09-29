using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Name of the folder
        string folderPath = "MyFolder";

        // File inside the folder
        string filePath = Path.Combine(
            folderPath,
            "student.txt"
        );

        // 1. Create folder
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);

            Console.WriteLine("Folder created.");
        }
        else
        {
            Console.WriteLine("Folder already exists.");
        }

        // 2. Create file and write data
        File.WriteAllText(
            filePath,
            "Name: Anil Pal\n" +
            "Course: BSc CSIT\n" +
            "College: Himalaya College of Engineering"
        );

        Console.WriteLine("File created.");

        // 3. Read file
        string content = File.ReadAllText(filePath);

        Console.WriteLine("\nFile Content:");
        Console.WriteLine(content);

        // 4. Display files
        Console.WriteLine("\nFiles inside MyFolder:");

        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        // 5. Display folders
        Console.WriteLine("\nFolders in current directory:");

        string[] folders = Directory.GetDirectories(".");

        foreach (string folder in folders)
        {
            Console.WriteLine(folder);
        }
    }
}
