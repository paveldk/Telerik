/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current 
 * directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the
 * finally block.
 * */

namespace DownloadFileProgram
{
    using System;
    using System.Net;

    class Program
    {
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                Uri address = new Uri("http://www.devbg.org/img/Logo-BASD.jpg");
                webClient.DownloadFile(address, "logo.jpg");
            }
            catch (ArgumentNullException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (WebException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (UriFormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (NotSupportedException fe)
            {
                Console.WriteLine(fe.Message);
            } 
            catch (HttpListenerException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (AccessViolationException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }

            // Maybe there are more exception but that's good enough for me :)
        }
    }
}
