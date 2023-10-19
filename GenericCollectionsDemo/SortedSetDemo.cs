using ClassLibrary;
using System;
using System.Collections.Generic;

namespace CollectionsLinkedListDemo
{
    public class SortedSetDemo
    {
        static void Main(string[] args)
        {
            SortedSet<string> SmartPhonesList = new SortedSet<string>();
            SmartPhonesList.Add("Iphones");
            SmartPhonesList.Add("Redmi");
            SmartPhonesList.Add("POCO");
            SmartPhonesList.Add("Asus");
            SmartPhonesList.Add("Sony");
            SmartPhonesList.Add("Infinix");
            SmartPhonesList.Add("BlackBerry");
            foreach (var item in SmartPhonesList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
