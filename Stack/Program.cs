using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string str = "()()()()()()";
            int i = 0;
            int l = 0;
            int x = 0;

            foreach (char k in str)
                stack.Push(k);
            
            while(stack.Count > 0)
            {
                char k = stack.Pop();
                if(stack.Count == 0){
                if(k == ')'){
                    x= 5000;
                }

                else if(k == ']'){
                    x= 5000;
                }

                else if(k == '}'){
                    x= 5000;
                }

            }
                if (k == '(')
                {
                    i++;
                }
                else if (k == ')')
                {
                    i--;
                }
                else if (k == '{')
                {
                    l++;
                }
                else if (k == '}')
                {
                    l--;
                }
                else if (k == '[')
                {
                    x++;
                }
                else if (k == ']')
                {
                    x--;
                }
            }
            if (i == 0 && x==0 && l==0)
            {
                Console.WriteLine("Balanserad");
            }
            else
            {
                Console.WriteLine("Inte balanserad");
            }
            
        }
    }
}