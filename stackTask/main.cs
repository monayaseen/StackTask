using System;
using System.Collections;
using System.Collections.Generic;

namespace stackTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListStack<int> list_stack= new MyListStack<int>();
            MyArrayStack<int> array_stack = new MyArrayStack<int>();
            
            //arrayStackTest
             array_stack.Push(8);
             array_stack.Push(9);
             array_stack.Push(10);
             array_stack.Push(11);
             array_stack.Push(12);
             array_stack.Pop();
             array_stack.Peek();
             array_stack.Push(13);
             array_stack.Print();
             array_stack.Clear();
             
             //listStackTest
             list_stack.Push(1);
             list_stack.Push(2);
             list_stack.Push(3);
             list_stack.Push(4);
             list_stack.Push(5);
             list_stack.Pop();
             list_stack.Peek();
             list_stack.Push(7);
             list_stack.Print();
            list_stack.Clear();
            list_stack.Print();


        }
    }
  
    
    
}