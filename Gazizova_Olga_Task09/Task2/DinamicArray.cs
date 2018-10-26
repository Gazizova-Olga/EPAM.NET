using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DynamicArray<T> : IEnumerable, IEnumerator where T : new()
    {
        private T[] array;
        private int index = -1;
        public int Length { get;set; }
        private int capasity;
        public int Capacity
        {
            get
            {
                return capasity;
            }
            set
            {
                capasity = array.Length;
            }
        }

        public DynamicArray() : this(8)
        {

        }

        public DynamicArray(int size)
        {
            array = new T[size];
        }

        public DynamicArray(T[] inputArray)
        {
            Array.Copy(inputArray, array, inputArray.Length);
            Length = inputArray.Length;
        }

        public DynamicArray(IEnumerable<T> origin)
        {
            array = new T[origin.Count()];
            int i = 0;
            foreach (var item in origin)
            {
                array[i] = item;
                i++;
            }
        }


        public void Add(T item)
        {
            Insert(item, Length);
        }

        public void AddRange(T[] inputArray)
        {
            int newSize = array.Length;
            while (inputArray.Length > newSize - Length)
            {
                newSize *= 2;
            }
            Array.Resize(ref array, newSize);
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                Add(inputArray[i]);
            }
        }

        public bool Remove(T item)
        {

            var itemIndex = Array.IndexOf(array, item);
            if (itemIndex != -1)
            {
                Array.Copy(array, itemIndex + 1, array, itemIndex, Length - itemIndex);
                Length--;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Insert(T item, int index)
        {
            if (index <= Length && index >= 0)
            {
                if (Capacity <= Length)
                {
                    Array.Resize(ref array, Capacity * 2);
                }
                Array.Copy(array, index, array, index + 1, Length - index);
                array[index] = item;
                Length++;
                return true;
            }
            else
            {

                throw new ArgumentOutOfRangeException();

            }
        }


        public T this[int index]
        {

            get
            {
                if (index >= Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return array[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else array[index] = value;
            }
        }


        public IEnumerator GetEnumerator()
        {
            return this;
        }


        public bool MoveNext()
        {
            if (index >= Length - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return array[index];
            }
        }

    }
}