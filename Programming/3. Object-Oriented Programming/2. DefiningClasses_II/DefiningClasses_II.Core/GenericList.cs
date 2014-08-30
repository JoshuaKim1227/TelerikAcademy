namespace DefiningClasses_II.Core
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        // Field
        private T[] array;
        private int count = 0;

        // Constructor
        public GenericList(int size)
        {
            this.array = new T[size];
            this.count = this.Count;
        }

        // Properties
        public T Value { get; set; }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        // Indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= this.array.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.array[index];
            }

            set
            {
                if (index >= 0 && index < this.array.Length)
                {
                    this.array[index] = value;
                }
            }
        }

        // Methods
        public void Add(T value)
        {
            if (this.Count >= this.array.Length)
            {
                this.ExpandArraySize();
            }

            this.array[this.Count] = value;
            this.Count++;
        }

        public void RemoveAt(int indexToRemove)
        {
            // Initializing data types
            int index = 0;
            T[] tempArray = new T[this.Count - 1];

            // If the given index is valid
            if (indexToRemove < this.Count)
            {
                // While the counter is NOT outside of the current list's length
                for (int counter = 0; counter < this.Count; counter++)
                {
                    // If the counter is NOT at the given index - copy the array item to a temporary array
                    if (counter != indexToRemove)
                    {
                        tempArray[index] = this.array[counter];
                        index++;
                    }
                }

                // Make new instance of array and copy the content of the temporary array to it
                this.array = new T[tempArray.Length];
                this.array = tempArray;

                // Set the new length of the list
                this.Count = this.array.Length;
            }
            else
            {
                throw new IndexOutOfRangeException("No such index in the list");
            }
        }

        public void InsertAt(T valueToInsert, int indexToInsert)
        {
            // Initializing data types
            T[] tempArray = new T[this.Count + 1];
            int index = 0;

            // If insert index is in the boundaries of the list
            if (indexToInsert < this.Count)
            {
                for (int counter = 0; counter < tempArray.Length; counter++)
                {
                    if (counter != indexToInsert)
                    {
                        tempArray[counter] = this.array[index];
                        index++;
                    }
                    else
                    {
                        tempArray[index] = valueToInsert;
                    }
                }
            }
            else
            {
                // While the index is in the list - copy values
                while (index < this.array.Length)
                {
                    tempArray[index] = this.array[index];
                    index++;
                }

                // Put the value to the end of the list 
                tempArray[tempArray.Length - 1] = valueToInsert;
            }

            // Make new instance of array and copy the content of the temporary array to it
            this.array = new T[tempArray.Length];
            this.array = tempArray;

            // Set the new length of the list
            this.Count = this.array.Length;
        }

        public int FindByValue(T value)
        {
            // Return the index of the searched value
            return Array.IndexOf(this.array, value);
        }

        public void Clear()
        {
            // Make new instance of the array - Clear it
            this.array = new T[this.Count];
        }

        public override string ToString()
        {
            // Initializing the info variable
            string info = string.Empty;

            // Formatting the output
            for (int index = 0; index < this.Count; index++)
            {
                info += string.Format("Index [{0}]: {1}\n", index, this.array[index]);
            }

            // Returning the result
            return info;
        }

        public void ExpandArraySize()
        {
            // Initializing temporary array twice the size of the original
            T[] tempArray = new T[this.array.Length * 2];

            // Copying the values from the original to the temporary array
            Array.Copy(this.array, tempArray, this.array.Length);

            // Pointing the temporary array to the original
            this.array = tempArray;
        }

        public int Min<T>() where T : IComparable<T>
        {
            int minIndex = 0;

            for (int index = 1; index < this.Count; index++)
            {
                if (this.array[minIndex].CompareTo(this.array[index]) == 1)
                {
                    minIndex = index;
                }
            }

            return minIndex;
        }

        public int Max<T>() where T : IComparable<T>
        {
            int maxIndex = 0;

            for (int index = 1; index < this.Count; index++)
            {
                if (this.array[maxIndex].CompareTo(this.array[index]) == -1)
                {
                    maxIndex = index;
                }
            }

            return maxIndex;
        }
    }
}