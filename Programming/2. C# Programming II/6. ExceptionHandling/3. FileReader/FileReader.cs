using System;
using System.IO;

public class FileReader
{
    public static void Main()
    {
        Console.WriteLine("Enter the path to the file you want to read.");
        Console.Write("==> ");

        try
        {
            string path = Console.ReadLine();
            string fileText = ReadFile(path);
            Console.WriteLine(fileText);
        }
        catch (DriveNotFoundException driveNotFoundEx)
        {
            Console.WriteLine(driveNotFoundEx.Message);
        }
        catch (DirectoryNotFoundException dirNotFoundEx)
        {
            Console.WriteLine(dirNotFoundEx.Message);
        }
        catch (PathTooLongException pathTooLongEx)
        {
            Console.WriteLine(pathTooLongEx.Message);
        }
        catch (FileNotFoundException fileNotFoundEx)
        {
            Console.WriteLine(fileNotFoundEx.Message);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch (UnauthorizedAccessException unauthorAccEx)
        {
            Console.WriteLine(unauthorAccEx.Message);
        }
        catch (NotSupportedException notSuppEx)
        {
            Console.WriteLine(notSuppEx.Message);
        }
    }

    public static string ReadFile(string pathToFile)
    {
        string fileOutputText = File.ReadAllText(pathToFile);

        return fileOutputText;
    }
}