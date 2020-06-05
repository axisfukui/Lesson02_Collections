using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask01
{
    //Реализовать интерфейс IComparer/ SortedList
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList(new MyComparer());
            sortedList[1] = "Первый";
            sortedList[13] = "Тренадцатый";
            sortedList[4] = "Четвертый";
            sortedList[8] = "Восьмой";
            sortedList[10] = "Десятый";

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " - "+item.Value);
            }
        }
    }

    class MyComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(y, x); //Сортировка по убыванию
            //return comparer.Compare(x, y); //Сортировка по возрастанию
        }
    }
}
