using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask03
{
    //Создайте класс MyComperer, реализующий интерфейс IEqualityComparer.Создайте коллекцию Hashtable, работающую так, что сравнение элементов 
    //должно проводиться по хеш коду верхнего регистра.Заполните коллекцию строковыми значениями дней недели(с большой буквы) и значениями
    //порядкового номера дня в неделе.Добавьте в коллекцию «ПоНеДеЛьнИк» - 01.
    //Выведите на экран все элементы коллекции.

    class MyComparer : IEqualityComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        
        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToUpperInvariant().GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dayofWeek = new Hashtable(new MyComparer());
            dayofWeek["Понедельник"] = 01;
            dayofWeek["Вторник"] = 02;
            dayofWeek["Среда"] = 03;
            dayofWeek["Четверг"] = 04;
            dayofWeek["Пятница"] = 05;
            dayofWeek["Суббота"] = 06;
            dayofWeek["Воскресенье"] = 07;

            foreach (DictionaryEntry item in dayofWeek)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine(new string('-',50));
            dayofWeek["ПоНеДеЛьнИк"] = 01;
            foreach (DictionaryEntry item in dayofWeek)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
