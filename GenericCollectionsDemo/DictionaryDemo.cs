using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace CollectionsLinkedListDemo
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, DictionarySmartPhone> Dic1 = new Dictionary<int, DictionarySmartPhone>();
            Dic1.Add(0, new DictionarySmartPhone() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            Dic1.Add(1, new DictionarySmartPhone() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            Dic1.Add(2, new DictionarySmartPhone() { IMEI = 12121212121210, Name = "Samsung", Model = "22 Ultra", Price = 120000 });

            Dictionary<int, DictionarySmartPhone> Dic2 = new Dictionary<int, DictionarySmartPhone>();
            Dic2.Add(0, new DictionarySmartPhone() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            Dic2.Add(5, new DictionarySmartPhone() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            Dic2.Add(6, new DictionarySmartPhone() { IMEI = 12121212121210, Name = "Asus", Model = "Rog 5", Price = 57000 });




            IEnumerable<KeyValuePair<int, DictionarySmartPhone>> SmartPhoneConcat = Dic1.Concat(Dic2);
            foreach (var item in SmartPhoneConcat)
            {
                Console.WriteLine($" IMEI : {item.Value.IMEI}  \n Name : {item.Value.Name} \n Model : {item.Value.Model}  \n Price : {item.Value.Price}");
            }

            Console.WriteLine("----------------------------------------");

            IEnumerable<KeyValuePair<int, DictionarySmartPhone>> SmartPhoneIntersect = Dic1.Intersect(Dic2);

            if (SmartPhoneIntersect != null)
            {
                foreach (KeyValuePair<int, DictionarySmartPhone> item in SmartPhoneIntersect)
                {
                    Console.WriteLine($"IMEI : {item.Value.IMEI} \n Name : {item.Value.Name}  \n Model : {item.Value.Model} \n Price : {item.Value.Price}");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.ReadLine();
        }
    }
}
