using System;
using System.Collections.Generic;
namespace PierrNameSpace
{
    public class ListOfOrders{
        public ListOfOrders()
        {
            List<Bread>ListBread = new List<Bread>();

        }
        public void AddBread(Bread new_bread)
        {
            ListBread.add(new_bread);
        }
        
    }
}