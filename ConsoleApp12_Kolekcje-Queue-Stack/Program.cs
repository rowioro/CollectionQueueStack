using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_Kolekcje_Queue_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolejka: ");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(99);
            Console.WriteLine(queue.Peek());

            Console.WriteLine("Stos: ");
            Stack<int> stack = new Stack<int>();
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            Console.WriteLine("zdejmuje ostatni ze stosu: "+stack.Pop());
            Console.WriteLine("pokazuje ostatni na stosie: "+stack.Peek());

            Console.ReadKey();
        }
    }
}
