using System;

namespace stackTask
{
    public class MyArrayStack<T> :IMyStack<T>

    {
        T[] arr = new T[100];  
        int item=0;
        
        public void Push(T value)
        {
            if (item>= arr.Length-1)  
            {  
                throw new InvalidOperationException("Stack is full");  
            } 
            arr[item] = value;  
            item++;
            
        }

        public T Pop()
        {
            if (item == 0)  
            {  
                throw new InvalidOperationException("stack is Empty");  
            }  
            item--;  
            return arr[item];
            
        }

        public T Peek()
        {
            if (item == 0)  
            {  
                throw new InvalidOperationException("stack is Empty");  
            }  
            return arr[item - 1];
            
        }

        public void Clear()
        {
            item = 0;          }

        public void Print()
        {
            if (item < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            else if (item==0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Array stack Items :");
                for (int i=0;i<item;i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            
        }
    }
}