using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPartTwo.Resources
{
    public class GenericList<T>
        where T: IEquatable<T>, /*so that i can Equals()*/
                 IComparable<T>  /*so that i can CompareTo()*/
                                 
    {       
        private T[] listOfElements;
        private int arrSize;
        
        public GenericList(int arrSize)
        {
            this.arrSize = arrSize;
            listOfElements = new T[arrSize];
        }

        public void AddElement(T element)
        {
            for(int i = 0; i< this.arrSize; i++)
            {
                if (listOfElements[i].Equals(default(T)))
                {
                    listOfElements[i] = element;
                    return;

                }
            }
            AutoGrowInternalArrSize();
            listOfElements[arrSize / 2] = element;
        }
        public T GetElement(int index)
        {
            return listOfElements[index];
        }
        public bool DeleteElement(int index)
        {
            try
            {
                listOfElements[index] = default(T);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public void InsertElement(T element,int index)
        {
            listOfElements[index] = element;
        }
        public void ClearList()
        {
            listOfElements = new T[arrSize];
        }
        public int GetIndexByValue(T element)
        {
            //TODO
            for(int i = 0; i < arrSize; i++)
            {
                if (listOfElements[i].Equals(element))
                {
                    return i;
                }
            }
        
            return -1;
        }
        public override string ToString()
        {
            string returnString = "";
            foreach(T item in listOfElements)
            {
                returnString += item.ToString()+"\n";
            }
            return returnString;
        }
        private void AutoGrowInternalArrSize()
        {
            int oldSize = this.arrSize;
            this.arrSize = arrSize * 2;
            T[] newResizedArr = new T[arrSize];
            for(int i = 0; i < oldSize; i++)
            {
                newResizedArr[i] = listOfElements[i];
            }
            listOfElements = newResizedArr;
        }
        public T Max()
        {
            return listOfElements.Max(); ;
        }
        public T Min()
        {
            return listOfElements.Min(); ;
        }
    }
}
