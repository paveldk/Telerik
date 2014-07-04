/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 * */
namespace URLParsing
{
    using System;

    class Program
    {
        static void Main()
        {
            //string url = "http://www.devbg.org/forum/index.php";
            string url = "http://dnes.dir.bg/news/delo-kostinbrod-buletini-15978479?nt=4";
            string protokol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            int index = 0;

            // we search for : 
            index = url.IndexOf(":");

            // and we get everything before that
            protokol = url.Substring(0, index);
            Console.WriteLine("[protocol] = {0}", protokol);

            // then we get all after : with index + 3 becouse we need to jump after :// 
            server = url.Substring(index + 3);
            
            // in this substring we search for first /
            index = server.IndexOf("/");
            
            // everything after it is the resourc
            resource = server.Substring(index);

            // and everything before is the server
            server = server.Substring(0, index);
            Console.WriteLine("[server] = {0}", server);
          
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
