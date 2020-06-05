using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask02
{
    //Создайте экземпляр коллекции Hashtable.Заполните экземпляр Hashtable 5 парами ключ-значение, состоящими из пароля и адреса электронной
    //почты.Выведите на экран значение пароля одной конкретной пары. Выведите на экран все пары ключ-значение.
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable emailList = new Hashtable();
            emailList["testemail1@mysite.com"] = "abcdef";
            emailList["testemail2@mysite.com"] = "tzgbdA";
            emailList["testemail3@mysite.com"] = "1254fgtr";
            emailList["testemail4@mysite.com"] = "12536tgd12";
            emailList["testemail5@mysite.com"] = "thzkl67859";

            Console.WriteLine($"testemail3@mysite.com - {emailList["testemail3@mysite.com"]}");

            Console.WriteLine(new string('-',50));
            foreach (DictionaryEntry item in emailList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
