using System;
using System.Collections;

namespace HomeTask02
{
    //Реализовать добавление в HashTable
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            //Добавление через метод Add();
            hashtable.Add(1, "Первый через Add()");

            //добавление через Индекс
            hashtable[3] = "Ключ тройка через индекс";
        }
    }
}
