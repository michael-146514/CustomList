using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member Variables (HAS A)
        private T[] items;
       private int capacity;
        private int count;

        

        //Constructor
        public CustomList()
        {

            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

       

        public T this[int index]
        {
            get
            {
               if(index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }
            }
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity => capacity;


        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (count == capacity)
            {
                ResizeArray();
            }

            items[count] = item;
            count++;
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        private void ResizeArray()
        {
            capacity *= 2;
            T[] newItems = new T[capacity];
            Array.Copy(items, newItems, count);
            items = newItems;
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(items, item, 0, count);

            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                count--;
                return true;
            }

            return false;
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
            }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
           
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
                if (i < count - 1)
                {
                    sb.Append("");
                }
            }
      
            return sb.ToString();

            //returns a single string that contains all items from array
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                result.Add(firstList[i]);
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                result.Add(secondList[i]);
            }

            return result;
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (!secondList.Contains(firstList[i]))
                {
                    result.Add(firstList[i]);
                }
            }

            return result;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
