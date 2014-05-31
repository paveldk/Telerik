using System;
using System.Collections.Generic;
using System.Text;

public class PermuteUtils
{
    // Returns an enumeration of enumerators, one for each permutation
    // of the input.
    static void Main()
    {
        int letterCount = int.Parse(Console.ReadLine());
        List<string> stringInput = new List<string>();
        for (int i = 0; i < letterCount; i++)
        {
            stringInput.Add(Console.ReadLine());   
        }
        
        Test(stringInput);
    }

    private static void Test(List<string> stringInput)
        {
            int count = 0;
            IList<IList<string>> perms = Permutations(stringInput);
            foreach (IList<string> perm in perms)
            {
                foreach (string s in perm)
                {
                    //Console.Write(s);
                    count++;
                }
                
            }
        Console.WriteLine(count);
        }
        private static IList<IList<T>> Permutations<T>(IList<T> list)
        {
            List<IList<T>> perms = new List<IList<T>>();
            if (list.Count == 0)
                return perms; // Empty list.
            int factorial = 1;
            for (int i = 2; i <= list.Count; i++)
                factorial *= i;
            for (int v = 0; v < factorial; v++)
            {
                List<T> s = new List<T>(list);                
                int k = v;
                for (int j = 2; j <= list.Count; j++)
                {
                    int other = (k % j);
                    T temp = s[j - 1];
                    s[j - 1] = s[other];
                    s[other] = temp;
                    k = k / j;
                }
                perms.Add(s);
            }
            return perms;
        }
    }