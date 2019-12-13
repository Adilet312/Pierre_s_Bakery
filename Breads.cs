using System;
namespace PierrNameSpace
{
    public class Bread
    {
        private string nameBread;
        private float price;
        public Bread(string given_name, float given_price)
        {
            this.nameBread = given_name;
            SetPriceBread(given_price);
            this.price = given_price;
        }
        public string GetBreadName() {return this.nameBread; }
        public void SetBreadName(string bread) {this.nameBread = bread; }
        public float GetPriceBread() { return this.price; }
        public void SetPriceBread(float new_price)
        {
            if(new_price<0)
            {
                throw new ArgumentException("Invalid data is given!");
            }
            this.price = new_price;
        }
        public string PrintBreadProperties()
        {
            string output = "Bread name: "+this.nameBread+" Price: "+this.price;
            return output;
        }

    }
}