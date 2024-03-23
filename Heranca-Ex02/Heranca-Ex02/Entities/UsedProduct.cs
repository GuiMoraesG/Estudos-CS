using System;

namespace Heranca_Ex02.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Manufacture {  get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufacture) : base(name, price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag() 
        {
            return $"{Name} (used) $ {Price} (Manufacture date: {Manufacture})";
        }
    }
}
