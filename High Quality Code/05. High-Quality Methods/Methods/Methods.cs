/* Take the VS solution "Methods" and refactor its code to follow the guidelines of 
 * high-quality methods. Ensure you handle errors correctly: when the methods cannot do what
 * their name says, throw an exception (do not return wrong result).Ensure good cohesion and 
 * coupling, good naming, no side effects, etc.
 * */
namespace Methods
{
    using System;

    internal class Methods
    {
        private static double CalcTriangleArea(double a, double b, double c)
        {
            // Промених грешния return -1 на хвърляне на Exception
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        // Променя името на метода
        private static string NumberToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return "Invalid number!";
        }

        // Промяна името на метода, както и хвърляне на Exception
        private static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("There is no elements inputed");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        // Промяна името на метода, типа на String, както и връщането на стойността. Ползването на Console = Tight coupling 
        private static string FormatNumber(object number, string format)
        {
            string formatedString = string.Empty;
            if (format == "f")
            {
                formatedString = string.Format("{0:f2}", number);
            }

            if (format == "%")
            {
                formatedString = string.Format("{0:p0}", number);
            }

            if (format == "r")
            {
                formatedString = string.Format("{0,8}", number);
            }

            return formatedString;
        }

        // Премахнах и изведох в нов метод проверката за позиционирането на линията, тук не и беше мястото - Side effects
        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double xDistance = x2 - x1;
            double yDistance = y2 - y1;

            double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));

            return distance;
        }

        // Новия метод за проверка на линията
        private static void CheckLinePosition(double x1, double y1, double x2, double y2, out bool isHorizontalLine, out bool isVerticalLine)
        {
            isHorizontalLine = y1 == y2;
            isVerticalLine = x1 == x2;
        }

        private static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToWord(5));
            
            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            
            Console.WriteLine(FormatNumber(1.3, "f"));
            Console.WriteLine(FormatNumber(0.75, "%"));
            Console.WriteLine(FormatNumber(2.30, "r"));

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            CheckLinePosition(3, -1, 3, 2.5, out horizontal, out vertical);
            Console.WriteLine(string.Format("Horizontal? {0}", horizontal));
            Console.WriteLine(string.Format("Vertical? {0}", vertical));

            // Хич не ми се връзват тези студенти в този клас, но нали домашното е за Методи, не за Класове реших да не ги местя...
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}