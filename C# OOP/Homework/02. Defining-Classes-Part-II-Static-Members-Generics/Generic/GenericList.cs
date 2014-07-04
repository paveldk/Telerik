namespace Generic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> where T : IComparable // restriction becouse of Min and Max
    {
        private const int defaultCapacity = 4;
      
        private int capacity;
        private int count = 0;
     
        public GenericList(int listCapacity)
        {
            this.Capacity = listCapacity;
            this.Elements = new T[this.Capacity];
        }

        public GenericList()
            : this(defaultCapacity)
        {
        }
      
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                this.capacity = value;
            }
        }

        private T[] Elements { get; set; }

        public T this[int index]
        {
            get
            {
                // Accessing to the index of the array
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Invalid index: {0}.", index));
                }

                T result = this.Elements[index];
                return result;
            }
        }

        public void Add(T element)
        {
            // we just add elements in the Array and increase the count, that's how we know how many elements we have
            if (this.count >= this.Elements.Length) 
            {
                throw new IndexOutOfRangeException(string.Format("The list capacity of {0} was exceeded.", this.Elements.Length));
            }

            this.Elements[this.count] = element;
            this.count++;

            this.IncreaseCapacity();
        }

        public void Remove(int index)
        {
            /* To remove a element, we simply need to copy the Array to another temp array
             * but without the element we want to remove. That's why we copy all to the element
             * and the all after the element. Finally we set elements to be equal of the temp
             * */
            if (index < 0 || index > this.count - 1)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Index isn't in the array bounds: 0 - {0}", this.Elements.Length - 1));
            }

            var temp = new T[this.count - 1];
            Array.Copy(this.Elements, 0, temp, 0, index);
            Array.Copy(this.Elements, index + 1, temp, index, this.count - index - 1);
            this.Elements = temp;
            this.count--;
        }

        public void Insert(int index, T element)
        {
            /* We want here to Insert element. To do that we need again temp array. This time
             * the temp array gonna be count + 1, becouse we need to INSERT one more. First
             * we Copy everything to the position where we want to insert the new element,
             * then we insert it and copy the rest, from position Index for the element array
             * but for position index + 1 for the temp and ofc to the count-1(the end).
             * */
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Index isn't in the array bounds: 0 - {0}", this.Elements.Length));
            }

            var temp = new T[this.count + 1];
            Array.Copy(this.Elements, 0, temp, 0, index);
            temp[index] = element;
            Array.Copy(this.Elements, index, temp, index + 1, this.count - index);
            this.Elements = temp;
            this.count++;

            this.IncreaseCapacity();
        }

        public void Clear()
        {
            /* we simply create empty temp array elements get's it's value - empty and we make
             * count 0
             * */
            var temp = new T[0];
            this.Elements = temp;
            this.count = 0;
        }

        public int Find(T element)
        {
            /* Something like IndexOf, we loop till we find the searched item, if not we
             * return -1.
             * */
            int index = -1;

            for (int i = 0; i < this.count; i++)
            {
                if (this.Elements[i] == (dynamic)element)
                {
                    index = i;
                    break;
                }
            }
            
            return index;
        }

        public void IncreaseCapacity()
        {
            if (this.count > this.Capacity)
            {
                this.Capacity *= 2;

                var temp = (T[])this.Elements.Clone();
                this.Elements = new T[this.Capacity];
                this.Elements = temp;
            }
        }

        // Need to add constraints for the types
        public T Max()
        {
            // with dynamic it's slower, but can't think another way - simple checker for maximum value
            dynamic max = this.Elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                T tempValue = (dynamic)this.Elements[i];
                if (tempValue.CompareTo(max) > 0)
                {
                    max = this.Elements[i];
                }
            }

            return max;
        }

        public T Min()
        {
            // with dynamic it's slower, but can't think another way - simple checker for minimum value
            dynamic min = this.Elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                T tempValue = (dynamic)this.Elements[i];
                if (tempValue.CompareTo(min) < 0)
                {
                    min = this.Elements[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var element in this.Elements)
            {
                result.AppendLine(string.Empty + element);
            }

            return result.ToString();
        }
    }
}
