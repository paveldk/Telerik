/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on
 * the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-
 * friendly error messages.
 * */
namespace ReadWinIniAndPrintsIt
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            try
            {
                string path = @"C:\WINDOWS\win.ini";  
 
                // using the path and ReadAllText we get the content of the file in variable text
                string text = File.ReadAllText(path);

                // and we print in the console
                Console.WriteLine(text);

                // if Error acures these are all IO exceptions:
            }            
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file don't exists");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The folder don't exists");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("The drive don't exists");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path to the file is too long");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Problem with loading the file");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }

            Console.ReadKey();
        }
    }
}
