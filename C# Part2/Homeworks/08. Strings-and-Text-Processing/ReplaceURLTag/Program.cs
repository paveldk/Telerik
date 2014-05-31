/*Write a program that replaces in a HTML document given as string all the tags 
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a 
 * training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the 
 * courses.</p>
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training 
 * course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 * */
namespace ReplaceURLTag
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string sourceHtmlText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string endHtmlText = string.Empty;

            // we're using Replace method for strings with text to replace and replacing text
            endHtmlText = sourceHtmlText.Replace("<a href=\"", "[URL=");

            // and that 3 times for the three differences:
            endHtmlText = endHtmlText.Replace("\">", "]");
            endHtmlText = endHtmlText.Replace("</a>", "[/URL]");

            // finally we print the replaces text
            Console.WriteLine(endHtmlText);
        }
    }
}
