using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            //capacity = 
            //count =
            //items = 

            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array

            if (count == capacity)
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count] = item;
            count++;

        }



        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
                return true;
            }
            return false;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //Append opening bracket
            sb.Append("[");

            //Iterates through the items and append them to the StringBuilder
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);

                if (i < count - 1)
                {
                    sb.Append(",");
                }
            }
            //Append closing bracket
            sb.Append("]");

            //returns a single string that contains all items from array

            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                result.Add(firstList[i]);
            }

            for (int i = 0; i< secondList.Count; i++)
            {
                result.Add(secondList[i]);
            }

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return result;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
                items[index] = value;
            }
        }
    }
}
