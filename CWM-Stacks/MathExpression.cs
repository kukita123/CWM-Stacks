using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Stacks
{
    class MathExpression
    {
        public bool IsCorrect(string input)
        {
            Stack<char> MathExpStack = new Stack<char>();

            //Simple logic, bad style:

            //foreach(char ch in input.ToCharArray())
            //{
            //    if (ch == '(' || ch == '<' || ch == '[' || ch == '{')
            //        MathExpStack.Push(ch);
            //    if (ch == ')' || ch == '>' || ch == ']' || ch == '}')
            //    {
            //        if (MathExpStack.Count == 0) return false;
            //        char top = MathExpStack.Pop();
            //        if (
            //            (ch == ')' && top != '(') ||
            //            (ch == '>' && top != '<') ||
            //            (ch == ']' && top != '[') ||
            //            (ch == '}' && top != '{') 
            //            )
            //            return false;                }
            //}
            //    if (MathExpStack.Count == 0)
            //        return true;
            //    else
            //        return false;
            //}

            //Better style - using private methods:

            foreach (char ch in input.ToCharArray())
            {
                if (isLeftBracket(ch))
                    MathExpStack.Push(ch);
                if (isRightBracket(ch))
                {
                    if (MathExpStack.Count == 0) return false;

                    char top = MathExpStack.Pop();
                    if (!bracketsMatch(top,ch)) return false;
                }
            }
            if (MathExpStack.Count == 0)
                return true;
            else
                return false;
        }
        private bool isLeftBracket(char ch)
        {
            return ch == '(' || ch == '<' || ch == '[' || ch == '{';
        }
        private bool isRightBracket(char ch)
        {
            return ch == ')' || ch == '>' || ch == ']' || ch == '}';
        }
        private bool bracketsMatch(char left, char right)
        {
            return (right == ')' && left != '(') ||
                        (right == '>' && left != '<') ||
                        (right == ']' && left != '[') ||
                        (right == '}' && left != '{');
        }
    }
}
