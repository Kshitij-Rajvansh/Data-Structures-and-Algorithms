using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "5", "6", "7", "*", "+", "1", "-" };

            int result = PostFixCalculator(str);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int PostFixCalculator(string[] args)
        {
            System.Collections.Generic.Stack<int> stack = new System.Collections.Generic.Stack<int>();

            foreach (string item in args)
            {
                int val;
                if (int.TryParse(item, out val))
                {
                    stack.Push(val);
                }
                else
                {
                    int rhs = stack.Pop();
                    int lhs = stack.Pop();

                    switch (item)
                    {
                        case "+":
                            stack.Push(rhs + lhs);
                            break;
                        case "-":
                            stack.Push(lhs - rhs);
                            break;
                        case "*":
                            stack.Push(rhs * lhs);
                            break;
                        case "/":
                            stack.Push(lhs / rhs);
                            break;
                        case "%":
                            stack.Push(lhs % rhs);
                            break;
                        default:
                            throw new ArgumentException($"Unrecognized token: {item}");
                    }
                }

            }

            return stack.Pop();
        }
    }
}
