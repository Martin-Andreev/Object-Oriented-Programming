namespace GenericList
{
    using System;
    using System.Text;
    
    [Version(0, 5)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int capacity;
        private int nextNumberIndex = 0;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.Elements = new T[this.capacity];
        }

        public T[] Elements
        {
            get
            {
                return this.elements;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Elements array cannot be null!");
                }

                this.elements = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Generic List capacity cannot be negative number!");
                }

                this.capacity = value;
            }
        }

        public int Count
        {
            get { return this.nextNumberIndex; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.nextNumberIndex - 1)
                {
                    throw new ArgumentOutOfRangeException("Index was outside the bounds of the array!");
                }

                return this.Elements[index];
            }
        }

        public void Add(T element)
        {
            if (this.nextNumberIndex == this.Capacity)
            {
                this.IncreaseArrayCapacity();
            }

            this.elements[this.nextNumberIndex] = element;
            this.nextNumberIndex++;
        }

        public void Remove(int index)
        {
            T[] newArray = new T[this.nextNumberIndex - 1];

            for (int currentPosition = 0; currentPosition < this.nextNumberIndex; currentPosition++)
            {
                if (currentPosition < index)
                {
                    newArray[currentPosition] = this.Elements[currentPosition];
                }
                else if (currentPosition > index)
                {
                    newArray[currentPosition - 1] = this.Elements[currentPosition];
                }
            }

            this.Elements = newArray;
            this.nextNumberIndex--;
        }

        public void Insert(int index, T value)
        {
            T[] newArray = new T[this.nextNumberIndex + 1];

            for (int currentPosition = 0; currentPosition < this.nextNumberIndex + 1; currentPosition++)
            {
                if (currentPosition < index)
                {
                    newArray[currentPosition] = this.Elements[currentPosition];
                }
                else if (currentPosition == index)
                {
                    newArray[currentPosition] = value;
                }
                else
                {
                    newArray[currentPosition] = this.Elements[currentPosition - 1];
                }
            }

            this.nextNumberIndex++;
            this.Elements = newArray;
            if (this.Capacity < this.nextNumberIndex)
            {
                this.IncreaseArrayCapacity();
            }
        }

        public void Clear()
        {
            this.Elements = new T[DefaultCapacity];
            this.nextNumberIndex = 0;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < this.Elements.Length; i++)
            {
                T a = this.Elements[i];
                if (this.Elements[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            return this.IndexOf(element) >= 0;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder elementsResult = new StringBuilder();

            for (int i = 0; i < this.Elements.Length; i++)
            {
                elementsResult.Append(this.Elements[i] + " ");
            }

            return elementsResult.ToString();
        }

        public T Max()
        {
            var max = this.Elements[0];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                if (max.CompareTo(this.Elements[i]) < 0)
                {
                    max = this.Elements[i];
                }
            }

            return max;
        }

        public T Min()
        {
            var min = this.Elements[0];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                if (min.CompareTo(this.Elements[i]) > 0)
                {
                    min = this.Elements[i];
                }
            }

            return min;
        }

        private void IncreaseArrayCapacity()
        {
            int newCapacity = this.capacity * 2;
            T[] newArray = new T[newCapacity];

            for (int i = 0; i < this.capacity; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.Capacity = newArray.Length;
            this.elements = newArray;
        }
    }
}