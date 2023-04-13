using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    internal class product
    {
        private string category;
        private string name;
        private int quantity;
        private float price;
        private string description;
        private double weight;
        private string brand;
        private product next;
        private product previous;
        public product(string category, string name, int quantity, float price, string description, double weight, string brand)
        {
            this.category = category;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.description = description;
            this.weight = weight;
            this.brand= brand;
        }

        public string Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Brand { get => brand; set => brand = value; }
        internal product Next { get => next; set => next = value; }
        internal product Previous { get => previous; set => previous = value; }
    }
}
