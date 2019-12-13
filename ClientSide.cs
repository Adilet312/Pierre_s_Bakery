using System;
using System.Collections.Generic;
namespace PierrNameSpace
{
    public class ClientProgram
    {
        public static void Main()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("++++++++++++++++++++++++++++++Welcome Pierre's Bakery!++++++++++++++++++++++++");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("-------------------------------               ---------------------------------");
            Console.WriteLine("| Simple bread, Price 5$      |               | Pastry: Biscotti,  Price: 10$ |");
            Console.WriteLine("| Bread: Sourdough, Price: 6$ |               | Pastry: Danish,    Price: 5$  |");
            Console.WriteLine("| Bread: Baquette, Price: 9$  |               | Pastry: Canolli,   Price: 12$ |");
            Console.WriteLine("| Bread: Pite, Price: 3$      |               | Pastry: Muffin,    Price: 3$  |");
            Console.WriteLine("| Bread: Challah, Price: 7$   |               | Pastry: Croissant, Price: 2$  |");
            Console.WriteLine("-------------------------------               ---------------------------------");
            Console.WriteLine("How many bread woud you like to buy:");
            int numberOfBreads = int.Parse(Console.ReadLine());
            //List<Bread>ListBread = new List<Bread>();
            ListOfOrders ListBread = new ListOfOrders();
            List<Pastry>ListPastry = new List<Pastry>();
            int userInput;
            Bread bread = null;
            while(numberOfBreads>0)
            {
                Console.WriteLine("Please enter 0 to select Simple Bread,which costs 5$.");
                Console.WriteLine("Please enter 1 to select Sourdough Bread,which costs 6$.");
                Console.WriteLine("Please enter 2 to select Baquette Bread,which costs 9$.");
                Console.WriteLine("Please enter 3 to select Pita Bread,which costs 3$.");
                Console.WriteLine("Please enter 4 to select Challah Bread,which costs 7$.");
                userInput = int.Parse(Console.ReadLine());
                // If user enters invalid number to choose order.The loop will iterate until user enters valid number.
                while(userInput<0 || userInput>4)
                {
                    Console.WriteLine("Please enter valid number to order!");
                    userInput = int.Parse(Console.ReadLine());
                }
                if(userInput==0)
                {
                    bread = new Bread("Simple Bread",5);
                }
                else if(userInput==1)
                {
                    bread = new Bread("Sourdough",6);
                }
                else if(userInput==2)
                {
                    bread = new Bread("Baquette",9);
                }
                else if(userInput==3)
                {
                    bread = new Bread("Pita",3);
                }
                else if(userInput==4)
                {
                    bread = new Bread("Challah",7);
                }
                ListBread.AddBread(bread);
                numberOfBreads--;

            }
            //for(int index=0; index<ListBread.Count;index++)
            //{
                Console.WriteLine(ListBread.getListBreads()+"Total Price: "+ListBread.GetTotalPriceForBreads());
            //}
        }
    }
}