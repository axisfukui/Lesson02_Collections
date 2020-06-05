using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask01
{
    //Создайте экземпляр класса Queue, который наполните строковыми значениями месяцев в году, 
    //начиная с января.Создайте экземпляр класса Stack.В цикле достаньте элементы коллекции Queue 
    //(удаляя их в очереди) и поместите их поочередно в экземпляр Stack.
    //Затем поочередно выведите на экран элементы Stack, извлекая их из коллекции с удалением.
    enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Queue Part
            Queue<string> queueMonths = new Queue<string>();
            for (int i = 0; i < 12; i++)
            {
                queueMonths.Enqueue(((Month)i).ToString());
            }

            Console.WriteLine("Queue Elemente");
            foreach (var item in queueMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-',50));

            //Stack Part
            Stack<string> stackMonth = new Stack<string>();

            for (int i = 0; i < 12; i++)
            {
                stackMonth.Push(queueMonths.Dequeue());
            }

            Console.WriteLine("Stack elemente");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(stackMonth.Pop());
            }

        }
    }
}
