using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    internal class placeOrderclass
    {
        private string name;
        private int quantity;
        private string category;
        private string brand;
        private float price;
        private string shopkeeperName;
        private float finalPrice;
        private placeOrderclass next;
        private placeOrderclass previous;

        public placeOrderclass(string name,int quantity,string category,string brand,float price,string shopkeeperName,float finalPrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.category = category;
            this.brand = brand;
            this.price = price;
            this.shopkeeperName = shopkeeperName;
            this.finalPrice = finalPrice;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Category { get => category; set => category = value; }
        public string Brand { get => brand; set => brand = value; }
        public float Price { get => price; set => price = value; }
        public string ShopkeeperName { get => shopkeeperName; set => shopkeeperName = value; }
        public float FinalPrice { get => finalPrice; set => finalPrice = value; }
        internal placeOrderclass Next { get => next; set => next = value; }
        internal placeOrderclass Previous { get => previous; set => previous = value; }
    }
}
