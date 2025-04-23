using System;
using System.Collections;

namespace UsingStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }            
        }
    }
}
