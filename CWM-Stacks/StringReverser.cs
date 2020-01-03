using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Stacks
{
    class StringReverser
    {
        public  String ReverseStringDemo(String input)
        {
            Stack<Char> MyCharStack = new Stack<char>();

            foreach(char ch in input.ToCharArray())
            {
                MyCharStack.Push(ch);
            }

            //String reversed = "";
            //while (MyCharStack.Count != 0)
            //{
            //    reversed += MyCharStack.Pop();
            //}

            StringBuilder reversed = new StringBuilder();
            while (MyCharStack.Count != 0)
            {
                reversed.Append(MyCharStack.Pop());
            }

            return reversed.ToString();
        }
    }
}
