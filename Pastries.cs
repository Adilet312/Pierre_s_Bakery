using System;
namespace PierrNameSpace
{
    public class Pastry
    {
        private string namePastry;
        private float price;
        public Pastry(string given_name, float given_price)
        {
            this.namePastry = given_name;
            SetPastryPrice(given_price);
            this.price = given_price;
        }
        public string GetNamePastry(){ return this.namePastry; }
        public void SetNamePastry(string new_name){this.namePastry = new_name; }
        public float GetPastryPrice(){ return this.price; }
        public void SetPastryPrice(float new_price)
        {
            if(new_price<0)
            {
                throw new ArgumentException("Invalid data is given!");
            }
            this.price = new_price; 
        }
        public string PrintPastryProperites()
        {
            string output = "Pastry: "+this.namePastry+", Price: "+this.price;
            return output;
        }

    }
}