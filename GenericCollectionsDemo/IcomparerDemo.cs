using ClassLibrary;
using System;
using System.Collections.Generic;


namespace CollectionsLinkedListDemo
{
    internal class IcomparerDemo
    {
        static void Main(string[] args)
        {

            List<SmartPhoneIcomparer> smartPhone = new List<SmartPhoneIcomparer>();
            smartPhone.Add(new SmartPhoneIcomparer() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            smartPhone.Add(new SmartPhoneIcomparer() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            smartPhone.Add(new SmartPhoneIcomparer() { IMEI = 56535653652145, Name = "Realme", Model = "9 Pro ", Price = 25000 });
            smartPhone.Add(new SmartPhoneIcomparer() { IMEI = 12121212121210, Name = "Samsung", Model = "22 Ultra", Price = 120000 });
            smartPhone.Add(new SmartPhoneIcomparer() { IMEI = 59864683468658, Name = "Nokia", Model = "6.1 pro", Price = 22000 });

            SmartPhoneIcomparer smart = new SmartPhoneIcomparer();
            smartPhone.Sort(smart);
            foreach (var item in smartPhone)
            {
                Console.WriteLine(item.IMEI);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Price);
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
