namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extensions
    {
        /*  Task 1
         * Implement an extension method Substring(int index, int length) for the class 
        * StringBuilder that returns new StringBuilder and has the same functionality as 
        * Substring in the class String.
        * */
        public static StringBuilder SubString(this StringBuilder str, int index, int length)
        {
            // we're using two things - method to string of the stringbuilder and method substring of the string
            StringBuilder result = new StringBuilder();
            result.Append(str.ToString().Substring(index, length));
            return result;
        }

        /*  Task 2
         * Implement a set of extension methods for IEnumerable<T> that implement the 
         * following group functions: sum, product, min, max, average
         * */
       
        public static T Sum<T>(this IEnumerable<T> arr) where T : IConvertible, IComparable<T>
        {
            // to get the first member we need it's index
            IEnumerator<T> index = arr.GetEnumerator();
            index.MoveNext();
            dynamic sum = index.Current;
            int count = 0;

            foreach (T element in arr)
            {
                /* since we already have first element we have to asure not to add it to sum
                 * That's why we add count and we add only if count isn't 0. It's gonna be 0
                 * only first time, so first element, which is already added won't be twice
                 * */               
                if (count != 0)
                {
                    dynamic e = element;
                    sum = sum + e;
                }

                count++;
            }

            return sum;
        }

        public static T Min<T>(this IEnumerable<T> arr) where T : IConvertible, IComparable<T>
        {
            // same here
            IEnumerator<T> index = arr.GetEnumerator();
            index.MoveNext();
            dynamic min = index.Current;
            foreach (T element in arr)
            {
                dynamic e = element;
                if (e.CompareTo(min) < 0)
                {
                    min = e;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> arr) where T : IConvertible, IComparable<T>
        {
            // and here
            IEnumerator<T> index = arr.GetEnumerator();
            index.MoveNext();
            dynamic max = index.Current;
            foreach (T element in arr)
            {
                dynamic e = element;
                if (e.CompareTo(max) > 0)
                {
                    max = e;
                }
            }

            return max;
        }

        // We need to add another restriction here with struct becouse, there is no way to product strings
        public static T Product<T>(this IEnumerable<T> arr) where T : struct, IConvertible, IComparable<T>
        {
            dynamic product = 1;
            foreach (T element in arr)
            {
                dynamic e = element;
                product = product * e;
            }

            return product;
        }

        // same here
        public static T Average<T>(this IEnumerable<T> arr) where T : struct, IConvertible, IComparable<T>
        {
            dynamic sum = 0;
            dynamic count = 0;
            foreach (T element in arr)
            {
                dynamic e = element;
                sum = sum + e;
                count++;
            }

            return sum / count;
        }
    }
}
