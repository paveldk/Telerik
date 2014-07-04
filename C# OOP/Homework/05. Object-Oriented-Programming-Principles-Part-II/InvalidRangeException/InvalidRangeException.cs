namespace CustomExceptions
{
    using System;
    
    class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string msg, T number, T min, T max)
            : base(msg)
        {
            this.MinValue = min;
            this.MaxValue = max;
            this.Value = number;
        }

        public T Value { get; private set; }

        public T MinValue { get; set; }

        public T MaxValue { get; set; }
    }
}