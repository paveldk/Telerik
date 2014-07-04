using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr.Length < 1)
        {
            throw new ArgumentException("Array must not be empty");
        }

        if (arr.Length < startIndex + count)
        {
            throw new ArgumentException("Array length must be more than " + (startIndex + count));
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentException("Invalid count!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    // In my oppinion exeptions can't be used for checking results, so I changed the way this methods works to bool and returning true or false
    public static bool IsPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static void Main()
    {     
        try
        {
            // Exeption On, , uncomment to see 
            /* var substr = Subsequence("Test".ToCharArray(), 2, 3);      
            Console.WriteLine(substr); */

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));

            // Exception On, uncomment to see 
            // Console.WriteLine(ExtractEnding("Hi", 100));
            int number = 23;

            if (IsPrime(number))
            {
                Console.WriteLine("The number {0} is prime", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not prime", number);
            }

            number = 33;

            if (IsPrime(number))
            {
                Console.WriteLine("The number {0} is prime", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not prime", number);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);

            List<Exam> stelaExams = new List<Exam>()
            {
            };

            // Exception On, uncomment to see
            // Student stela = new Student("Stela", "Petrova", stelaExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }       
        catch (Exception)
        {
            Console.WriteLine("Something very odd happent!");
        }   
    }
}
