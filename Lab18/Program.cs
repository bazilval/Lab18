using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Дана строка, содержащая скобки трёх видов 
 * (круглые, квадратные и фигурные) и любые другие символы. 
 * Проверить, корректно ли в ней расставлены скобки.
 * Например, в строке ([]{})[] скобки расставлены корректно, 
 * а в строке ([]] — нет. 
 * Указание: задача решается однократным проходом по символам 
 * заданной строки слева направо; 
 * для каждой открывающей скобки в строке в стек помещается 
 * соответствующая закрывающая, каждая закрывающая скобка 
 * в строке должна соответствовать скобке из вершины стека 
 * (при этом скобка с вершины стека снимается); 
 * в конце прохода стек должен быть пуст.*/
namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string str = Console.ReadLine();
            char t = '?';
            foreach (char s in str)
            {
                if (stack.Count!=0)
                {
                    switch (stack.Peek())
                    {
                        case '(':
                            t = ')';
                            break;
                        case '{':
                            t = '}';
                            break;
                        case '[':
                            t = ']';
                            break;
                        default:
                            break;
                    }
                }
                if ("({[".Contains(s))
                {
                    stack.Push(s);
                    continue;
                }
                if (")}]".Contains(s) && t == s)
                {
                    stack.Pop();
                    continue;
                }
                if (")}]".Contains(s) && t != s)
                {
                    break;
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены некорректно");
            }
            Console.ReadKey();
        }
    }
}
