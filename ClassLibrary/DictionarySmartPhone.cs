using System;


namespace ClassLibrary
{
    public class DictionarySmartPhone : IEquatable<DictionarySmartPhone>
    {
        public long IMEI { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public bool Equals(DictionarySmartPhone other)
        {
            if (other is null)
                return false;

            return this.IMEI == other.IMEI && this.Name == other.Name && this.Model == other.Model && this.Price == other.Price;
        }

        public override bool Equals(object obj) => Equals(obj as DictionarySmartPhone);
        public override int GetHashCode() => (IMEI, Name, Model, Price).GetHashCode();
    }
}
