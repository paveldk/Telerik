/* Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement 
 * IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 * */
namespace BitArray64
{
    using System;

    class MainClass
    {
        static void Main()
        {
            BitArray64 firstNumber = new BitArray64(478l);
            BitArray64 secondNumber = new BitArray64(479l);

            Console.WriteLine("Bits of the number {0}", firstNumber.Number);
            foreach (var bit in firstNumber)
            {
                Console.Write(bit + " ");
            }

            Console.WriteLine("Bits of the number {0}", secondNumber.Number);
            foreach (var bit in secondNumber)
            {
                Console.Write(bit + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Bit from number {0} at position 0 is {1}", firstNumber.Number, firstNumber[0]);

            Console.WriteLine();
            Console.WriteLine("Bit from number {0} at position 0 is {1}", secondNumber.Number, secondNumber[0]);

            Console.WriteLine("Hash code of {0} is {1}", firstNumber.Number, firstNumber.GetHashCode());

            Console.WriteLine("Is {0} == {1} -> {2}", firstNumber.Number, secondNumber.Number, firstNumber == secondNumber);
            Console.WriteLine("Is {0} != {1} -> {2}", firstNumber.Number, secondNumber.Number, firstNumber != secondNumber);
            Console.WriteLine("Is {0} equals {1} -> {2}", firstNumber.Number, secondNumber.Number, firstNumber.Equals(secondNumber));
        }
    }
}
