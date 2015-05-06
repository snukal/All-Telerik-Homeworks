namespace _64BitsArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BitArray64<T>: IEnumerable<T>
    {
        private T[] elements;
        private const int DEFAULTCAPACITY = 64;
        private int count;
        private int currentCapacity;

        public BitArray64(int capacity = BitArray64<T>.DEFAULTCAPACITY)
        {
            this.elements = new T[capacity];
            currentCapacity = capacity;
            this.count = 64;
        }
        public T this[int index]
        {
            get { return this.elements[index]; }
            set 
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("This is a 64 bit array. Check your index!");
                }
                this.elements[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in this.elements)
            {
                yield return t;
            }
        }
         IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
         public override string ToString()
         {
             var builder = new StringBuilder();
             for (int i = 0; i < count; i++)
             {
                 builder.AppendFormat("{0} ", elements[i]);
             }
             return builder.ToString();
         }
         public override int GetHashCode()   //TODO test this method
         {
             return this.GetHashCode() << 17 ^ this.GetHashCode() >> 17;
         }
         public override bool Equals(object first)   
        {
            if (first == null)
            {
                return false;
            }
            // If parameter cannot be cast to Point return false.
            BitArray64<T> second = first as BitArray64<T>;
            if ((System.Object)second == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (first == second);
        }
         public static bool operator ==(BitArray64<T> first, BitArray64<T> second)
         {
             // If both are null, or both are same instance, return true.
             if (ReferenceEquals(first, second))
             {
                 return true;
             }
             // If one is null, but not both, return false.
             if (((object)first == null) || ((object)second == null))
             {
                 return false;
             }
             // Return true if the fields match:
             return first.Equals(second);
         }
         public static bool operator !=(BitArray64<T> first, BitArray64<T> second)
         {
             return !(first.Equals(second));
         }
    }
}
