using System;
using System.IO;
using System.Net;

public class DownloadFileFromNet
{
    static WebClient downloadClient = new WebClient();

    public static void Main()
    {
        try
        {
            DownloadFile();
            Console.WriteLine("File successfully downloaded to:\n {0}", Directory.GetCurrentDirectory());
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch (WebException webEx)
        {
            Console.WriteLine(webEx.Message);
        }
        finally
        {
            downloadClient.Dispose();
        }
    }

    public static void DownloadFile()
    {
        downloadClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "Logo-BASD.jpg");
    }
}