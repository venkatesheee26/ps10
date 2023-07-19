using System;
using System.IO;

class Program
{
    private static string basePath = "D:\\ps";

    static void Main(string[] args)
    {
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Append");
        Console.WriteLine("4. Delete");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the filename: ");
                string createFileName = Console.ReadLine();
                Console.Write("Enter the content: ");
                string content = Console.ReadLine();
                CreateFile(createFileName, content);
                break;
            case 2:
                Console.Write("Enter the filename to read: ");
                string readFileName = Console.ReadLine();
                ReadFile(readFileName);
                break;
            case 3:
                Console.Write("Enter the filename to append: ");
                string appendFileName = Console.ReadLine();
                Console.Write("Enter the content to append: ");
                string appendContent = Console.ReadLine();
                AppendToFile(appendFileName, appendContent);
                break;
            case 4:
                Console.Write("Enter the filename to delete: ");
                string deleteFileName = Console.ReadLine();
                DeleteFile(deleteFileName);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        
    }
}
        

    static void CreateFile(string fileName, string content)
    {
        string filePath = Path.Combine(basePath, fileName);

      
        if (File.Exists(filePath))
        {
            Console.WriteLine("File already exists. Use a different name.");
            return;
        }

        try
        {
          
            File.WriteAllText(filePath, content);
            Console.WriteLine("File created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while creating the file: " + ex.Message);
        }
    }

    static void ReadFile(string fileName)
    {
        string filePath = Path.Combine(basePath, fileName);

       
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
           
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while reading the file: " + ex.Message);
        }
    }

    static void AppendToFile(string fileName, string content)
    {
        string filePath = Path.Combine(basePath, fileName);

      
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            
            File.AppendAllText(filePath, content);
            Console.WriteLine("Content appended successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while appending to the file: " + ex.Message);
        }
    }

    static void DeleteFile(string fileName)
    {
        string filePath = Path.Combine(basePath, fileName);

        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
         
            File.Delete(filePath);
            Console.WriteLine("File deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while deleting the file: " + ex.Message);
        }
    }
}





