using System;
using System.Collections.Generic;
using System.Linq;
    public class InvalidRangeException<T>: ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeException(string msg, T start, T end) : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

    }