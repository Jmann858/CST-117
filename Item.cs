using System;

namespace Milestone_2
{
    class Item
    {
        private string _brand;

        public string GetBrand()
        {
            return _brand;
        }

        public void SetBrand(string brand)
        {
            _brand = brand;
        }

        private string _material;

        public string GetMaterial()
        {
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        private string _type;

        public string GetType()
        {
            return _type;
        }

        public void SetType(string type)
        {
            _type = type;
        }

        private double _price;

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        private int _quantity;

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
    }
}
