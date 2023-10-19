using ClassLibrary;
using System;
using System.Collections.Generic;


namespace CollectionsLinkedListDemo
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {

            LinkedList<SmartPhone> SPLinkekList = new LinkedList<SmartPhone>();
            SPLinkekList.AddFirst(new SmartPhone() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            SPLinkekList.AddLast(new SmartPhone() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            LinkedListNode<SmartPhone> node1 = SPLinkekList.AddAfter(SPLinkekList.First, new SmartPhone() { IMEI = 56535653652145, Name = "Realme", Model = "9 Pro ", Price = 25000 });
            SPLinkekList.AddAfter(node1, new SmartPhone() { IMEI = 12121212121210, Name = "Asus", Model = "Rog 5", Price = 57000 });
            SPLinkekList.AddBefore(node1, new SmartPhone() { IMEI = 12121212121210, Name = "Black Berry", Model = "6 max", Price = 30000 });
            foreach (var item in SPLinkekList)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
