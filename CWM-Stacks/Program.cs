using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Stacks
{
    class Program
    {
        public static void IntStackDemo()
        {
            Stack<int> MyIntStack = new Stack<int>();
            MyIntStack.Push(10);
            MyIntStack.Push(20);
            MyIntStack.Push(30);
            MyIntStack.Push(40);

            int top = MyIntStack.Peek();
            Console.WriteLine("Top of the stack: " + top);
            Console.WriteLine();

            Console.WriteLine("The whole stack (turned to the array):");
            int[] MyArray = MyIntStack.ToArray();
            foreach (int x in MyArray)
                Console.WriteLine(x);
            Console.WriteLine();

            Console.WriteLine("The whole stack (getting the item fromthe top):");
            while (MyIntStack.Count != 0)
            {
                Console.WriteLine(MyIntStack.Pop());
            }            
        }

        static void Main(string[] args)
        {
            //Simple stack demo:
            IntStackDemo();
            Console.ReadKey();

            //Reversing a string - base for of UnDo and Back/Forward:
            StringReverser reverser = new StringReverser();
            String reversed = reverser.ReverseStringDemo("abcd");
            Console.WriteLine(reversed);
            Console.ReadKey();

            //Checking math expression:
            MathExpression expression = new MathExpression();
            string exp = "(a+b)";
            Console.WriteLine(expression.IsCorrect(exp));
            Console.ReadKey();

            //Minimum of the stack:
            // We need two stacks to implement a min stack.
            // One stack holds the values, the other stack
            // (called minStack) holds the minimums on the top.
            MinStackSolution minimum = new MinStackSolution();
            minimum.push(1);
            minimum.push(5);
            minimum.push(1);
            minimum.push(5);
            minimum.push(-11);
            Console.WriteLine(minimum.min());
            minimum.pop();
            Console.WriteLine(minimum.min());
            Console.ReadKey();
        }
    }
}
