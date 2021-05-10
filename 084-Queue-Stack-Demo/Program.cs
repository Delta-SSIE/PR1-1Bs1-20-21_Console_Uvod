using System;
using System.Collections.Generic;

namespace _084_Queue_Stack_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> numQueue = new Queue<int>();
            //PrintQueue(numQueue);
            //numQueue.Enqueue(1);
            //PrintQueue(numQueue);
            //numQueue.Enqueue(5);
            //numQueue.Enqueue(19);
            //numQueue.Enqueue(8);
            //PrintQueue(numQueue);

            //int d = numQueue.Dequeue();
            //Console.WriteLine(d);
            //PrintQueue(numQueue);
            //numQueue.Enqueue(12);
            //d = numQueue.Dequeue();
            //Console.WriteLine(d);
            //PrintQueue(numQueue);
            
            
            Stack<int> numStack = new Stack<int>();
            PrintStack(numStack);
            numStack.Push(1);
            PrintStack(numStack);
            numStack.Push(5);
            numStack.Push(19);
            numStack.Push(8);
            PrintStack(numStack);

            int d = numStack.Pop();
            Console.WriteLine(d);
            PrintStack(numStack);
            numStack.Push(12);
            PrintStack(numStack);
            d = numStack.Pop();
            Console.WriteLine(d);
            PrintStack(numStack);

        }

        static void PrintQueue(Queue<int> q)
        {
            Console.WriteLine( q.Count + "  elements : [" +  String.Join(", ", q) + "]" );
        }
        static void PrintStack(Stack<int> s)
        {
            Console.WriteLine( s.Count + "  elements : [" +  String.Join(", ", s) + "]" );
        }
    }
}
