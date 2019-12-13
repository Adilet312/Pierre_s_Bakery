using System;
using System.Collections.Generic;
namespace PierrNameSpace
{
    public class ListOfOrders
    {
        private List<Bread> ListBread;
        private List<Pastry> ListPastry;
        public ListOfOrders()
        {
            ListBread = new List<Bread>();
            ListPastry =new List<Pastry>();

        }
        public void AddBread(Bread new_bread)
        {
            ListBread.Add(new_bread);
        }
        public void AddPastry(Pastry new_pastry)
        {
            ListPastry.Add(new_pastry);
        }
        public float GetTotalPriceForPastries()
        {
            float totalCost = 0;
            float finalCostAfterDiscount = 0;
            if(ListPastry.Count>1)
            {
                // Firstly, I sum up all bread's prices
                for(int idx = 0; idx<ListPastry.Count; idx++)
                {
                    totalCost+=ListPastry[idx].GetPastryPrice();
                }

                    finalCostAfterDiscount = totalCost/2;
            }
            else if(ListPastry.Count==1)
            {
                finalCostAfterDiscount = ListPastry[0].GetPastryPrice();
            }
            else
            {
                return 0;
            }
            return finalCostAfterDiscount;

        }
        public float GetTotalPriceForBreads()
        {
            float totalCost = 0;
            float finalCostAfterDiscount = 0;
            if(ListBread.Count>1)
            {
                // Firstly, I sum up all bread's prices
                for(int idx = 0; idx<ListBread.Count; idx++)
                {
                    totalCost+=ListBread[idx].GetPriceBread();
                }

                    finalCostAfterDiscount = totalCost/2;
            }
            else if(ListBread.Count==1)
            {
                finalCostAfterDiscount = ListBread[0].GetPriceBread();
            }
            else
            {
                return 0;
            }
            return finalCostAfterDiscount;
        } 
        public float GetTotalPrice()
        {
            float total = GetTotalPriceForBreads()+GetTotalPriceForPastries();
            return total;
        }   
        public void RemoveBreadByName(string name)
        {
            for(int index=0; index<ListBread.Count; index++)
            {
                if(ListBread[index].GetBreadName()==name)
                {
                    ListBread.Remove(ListBread[index]);
                }
            }
        }
        
        public void RemoveBreadByPrice(float price)
        {
            for(int index=0; index<ListBread.Count; index++)
            {
                if(ListBread[index].GetPriceBread()==price)
                {
                    ListBread.Remove(ListBread[index]);
                }
            }
        }

        public void ReplaceBreadByName(Bread new_bread,string old_one)
        {
             for(int index=0; index<ListBread.Count; index++)
            {
                if(ListBread[index].GetBreadName()==old_one)
                {
                    ListBread.Remove(ListBread[index]);
                    ListBread.Add(new_bread);
                }
            }
        }
        public string GetListBreadsAndPastries()
        {
            string output="";
            for(int idx=0; idx<ListBread.Count;idx++)
            {
                output+=ListBread[idx].PrintBreadProperties()+"\n";
            }
            for(int idx=0; idx<ListPastry.Count; idx++)
            {
                output+=ListPastry[idx].PrintPastryProperites()+"\n";
            }
            return output;
        }

       
    }
}