using System;
using System.Collections.Generic;

namespace stackTask
{
    public class MyListStack<T> :IMyStack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        
                public void Push(T value)
                {
                    list.AddFirst(value);
                    
                }
        
                public T Pop()
                {
                    if (list.Count == 0)  
                    {  
                        throw new InvalidOperationException("stack is Empty");    
                    }  
                    T value = list.First.Value;  
                    list.RemoveFirst();
                    return value;
                }
        
                public T Peek()
                {
                    if (list.Count == 0)  
                    {  
                        throw new InvalidOperationException("stack is Empty");   
                    }  
                    return list.First.Value; 
                }
        
                public void Clear()
                {
                    list.Clear();
                }
        
                public void Print()
                {
                    if (list.Count == 0)
                    {
                        throw new InvalidOperationException(" Stack is empty");
                    }
                    else
                    {
                        Console.WriteLine("List stack Items :");
                        foreach (T i in list)
                        {
                            Console.WriteLine(i);
                        }
                       
                    }
                }
                
            }
}
