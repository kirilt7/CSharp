//04. Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. Be sure to catch all 
//exceptions and to free any used resources in the finally block.
using System;
using System.Net;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter URL to download from: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter name for the file: ");
        string fileName = Console.ReadLine();

        WebClient webClient = new WebClient();
        try
        {
            Console.WriteLine("Downloading file from \"{0}\" .......\n\n", adress);
            // Download the Web resource and save it into the current filesystem folder.
            webClient.DownloadFile(adress, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, adress);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Either adress parameter is null or filename parameter is null!");
        }
        catch (WebException)
        {
            Console.WriteLine("The URI adress is invalid,filename is null or empty or an error occurred while downloading data!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            webClient.Dispose();
        }
        
    }
}
