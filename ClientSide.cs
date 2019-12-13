using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            Regex regex = new Regex("^[0-9]+$");
            string input = Console.ReadLine();
            //Data validation for numbers [0-9]
            while(!regex.IsMatch(input))
            {
                Console.WriteLine("THis is not valid data to process!");
                Console.WriteLine("How many bread woud you like to buy:");
                input = Console.ReadLine();
            }
            int numberOfBreads = int.Parse(input);
            ListOfOrders ListBreadAndPastry = new ListOfOrders();
            int userInput;
            Bread bread = null;
            Pastry pastry = null;
            while(numberOfBreads>0)
            {
                Console.WriteLine("Please enter 1 to select Simple Bread,which costs 5$.");
                Console.WriteLine("Please enter 2 to select Sourdough Bread,which costs 6$.");
                Console.WriteLine("Please enter 3 to select Baquette Bread,which costs 9$.");
                Console.WriteLine("Please enter 4 to select Pita Bread,which costs 3$.");
                Console.WriteLine("Please enter 5 to select Challah Bread,which costs 7$.");
                userInput = int.Parse(Console.ReadLine());
                // If user enters invalid number to choose order.The loop will iterate until user enters valid number.
                while(userInput<1 || userInput>5)
                {
                    Console.WriteLine("This is not a valid number to make a selection!");
                    Console.WriteLine("Please enter 1 to select Simple Bread,which costs 5$.");
                    Console.WriteLine("Please enter 2 to select Sourdough Bread,which costs 6$.");
                    Console.WriteLine("Please enter 3 to select Baquette Bread,which costs 9$.");
                    Console.WriteLine("Please enter 4 to select Pita Bread,which costs 3$.");
                    Console.WriteLine("Please enter 5 to select Challah Bread,which costs 7$.");

                    userInput = int.Parse(Console.ReadLine());
                }
                if(userInput==1)
                {
                    bread = new Bread("Simple Bread",5);
                }
                else if(userInput==2)
                {
                    bread = new Bread("Sourdough",6);
                }
                else if(userInput==3)
                {
                    bread = new Bread("Baquette",9);
                }
                else if(userInput==4)
                {
                    bread = new Bread("Pita",3);
                }
                else if(userInput==5)
                {
                    bread = new Bread("Challah",7);
                }
                ListBreadAndPastry.AddBread(bread);
                numberOfBreads--;

            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("| Pastry: Biscotti,  Price: 10$ |");
            Console.WriteLine("| Pastry: Danish,    Price: 5$  |");
            Console.WriteLine("| Pastry: Canolli,   Price: 12$ |");
            Console.WriteLine("| Pastry: Muffin,    Price: 3$  |");
            Console.WriteLine("| Pastry: Croissant, Price: 2$  |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("How many pastries would you like to buy: ");
            input = Console.ReadLine();
            //Data validation for numbers [0-9]
            while(!regex.IsMatch(input))
            {
                Console.WriteLine("This is not valid data to process!: ");
                Console.WriteLine("Please Enter number : How many pastries would you like to buy: ");
                input = Console.ReadLine();
            }
            int numberOfPastries = int.Parse(input);
            while(numberOfPastries>0)
            {
                Console.WriteLine("Please enter 1 to select Pastry: Biscotti, which costs 6$.");
                Console.WriteLine("Please enter 2 to select Pastry: Danish, which costs 7$.");
                Console.WriteLine("Please enter 3 to select Pastry: Canolli, which costs 8$.");
                Console.WriteLine("Please enter 4 to select Pastry: Muffin, which costs 9$.");
                Console.WriteLine("Please enter 5 to select Pastry: Croissant, which costs 1$.");
                userInput = int.Parse(Console.ReadLine());
                // If user enters invalid number to choose order.The loop will iterate until user enters valid number.
                while(userInput<1 || userInput>5)
                {
                    Console.WriteLine("This is not a valid number to select options!");
                    Console.WriteLine("Please enter 1 to select Pastry: Biscotti, which costs 6$.");
                    Console.WriteLine("Please enter 2 to select Pastry: Danish, which costs 7$.");
                    Console.WriteLine("Please enter 3 to select Pastry: Canolli, which costs 8$.");
                    Console.WriteLine("Please enter 4 to select Pastry: Muffin, which costs 9$.");
                    Console.WriteLine("Please enter 5 to select Pastry: Croissant, which costs 1$.");

                    userInput = int.Parse(Console.ReadLine());
                }
                  if(userInput==1)
                {
                    pastry = new Pastry("Biscotti",6);
                }
                else if(userInput==2)
                {
                    pastry = new Pastry("Danish",7);
                }
                else if(userInput==3)
                {
                    pastry = new Pastry("Canolli",8);
                }
                else if(userInput==4)
                {
                    pastry = new Pastry("Muffin",9);
                }
                else if(userInput==5)
                {
                    pastry = new Pastry("Croisant",1);
                }
                ListBreadAndPastry.AddPastry(pastry);
                numberOfPastries--;

            }
            string orders_and__totalCost = "List of orders:\n"+ListBreadAndPastry.GetListBreadsAndPastries()+"\n"+
                                           "Price for Breads: "+ListBreadAndPastry.GetTotalPriceForBreads()+".00 $\n"+
                                           "Price for Pastries: "+ListBreadAndPastry.GetTotalPriceForPastries()+".00 $\n"+
                                           "Total Price: "+ListBreadAndPastry.GetTotalPrice()+".00 $";
            
                Console.WriteLine(orders_and__totalCost);
            
        }
    }
}