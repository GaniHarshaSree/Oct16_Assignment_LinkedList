using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class SmartPhoneIcomparer : IComparer<SmartPhoneIcomparer>
    {
      
            public long IMEI { get; set; }
            public string Name { get; set; }
            public string Model { get; set; }
            public int Price { get; set; }
        

        public int Compare(SmartPhoneIcomparer x, SmartPhoneIcomparer y)
        {
            SmartPhoneIcomparer s1 = x as SmartPhoneIcomparer;
            SmartPhoneIcomparer s2 = y as SmartPhoneIcomparer;
            return s1.Name.CompareTo(s2.Name);
        }
    }
}
