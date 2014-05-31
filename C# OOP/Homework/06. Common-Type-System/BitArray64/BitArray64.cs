namespace BitArray64
{
    using System;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        private Random rand = new Random();

        public BitArray64(ulong bits = 0)
        {
            this.Number = bits;
        }

        public ulong Number { get; set; }

        public override bool Equals(object obj)
        {
            BitArray64 value = obj as BitArray64;
            if (value == null)
            {
                return false;
            }
            if (this.Number != value.Number)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {           
            int result = rand.Next(0,101) + this.Number.GetHashCode();
            return result;
        }

        public static bool operator ==(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }

        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return !BitArray64.Equals(firstNumber, secondNumber);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index out of range(0, 63)");
                }
                int mask = 1 << index;
                int result = (int)(this.Number & (ulong)mask);
                return result >> index;
            }
        }
    
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
 	        throw new NotImplementedException();
        }
    }
}
