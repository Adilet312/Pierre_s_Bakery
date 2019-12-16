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
            Console.WriteLine("       BUY 2 SIMPLE BREAD GET ONE FREE OR BUY 3 CROISSANT FOR 5$!              ");
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
            int choice = 1;
            while(numberOfBreads>0)
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("|| Please Enter==> 1 for  Simple Bread,which costs 5$.   ||");
                Console.WriteLine("|| Please Enter==> 2 for  Sourdough Bread,which costs 6$.||");
                Console.WriteLine("|| Please Enter==> 3 for  Baquette Bread,which costs 9$. ||");
                Console.WriteLine("|| Please Enter==> 4 for  Pita Bread,which costs 3$.     ||");
                Console.WriteLine("|| Please Enter==> 5 for  Challah Bread,which costs 7$.  ||");
                Console.WriteLine("+++++++++++++++++++++++++CHOICE: "+choice+"+++++++++++++++++++++++++");
                userInput = int.Parse(Console.ReadLine());
                // If user enters invalid number to choose order.The loop will iterate until user enters valid number.
                while(userInput<1 || userInput>5)
                {
                    Console.WriteLine("This is not a valid number to make a selection!");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("|| Please Enter==> 1 for  Simple Bread,which costs 5$.   ||");
                    Console.WriteLine("|| Please Enter==> 2 for  Sourdough Bread,which costs 6$.||");
                    Console.WriteLine("|| Please Enter==> 3 for  Baquette Bread,which costs 9$. ||");
                    Console.WriteLine("|| Please Enter==> 4 for  Pita Bread,which costs 3$.     ||");
                    Console.WriteLine("|| Please Enter==> 5 for  Challah Bread,which costs 7$.  ||");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
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
                choice++;

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
            int choiceNumber = 1;
            while(numberOfPastries>0)
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("|| Please Enter==> 1 for  Pastry: Biscotti, which costs 6$. ||");
                Console.WriteLine("|| Please Enter==> 2 for  Pastry: Danish, which costs 7$.   ||");
                Console.WriteLine("|| Please Enter==> 3 for  Pastry: Canolli, which costs 8$.  ||");
                Console.WriteLine("|| Please Enter==> 4 for  Pastry: Muffin, which costs 9$.   ||");
                Console.WriteLine("|| Please Enter==> 5 for  Pastry: Croissant, which costs 1$.||");
                Console.WriteLine("+++++++++++++++++++Choice: "+choiceNumber+" ++++++++++++++++++++++++++++++++++");
                userInput = int.Parse(Console.ReadLine());
                // If user enters invalid number to choose order.The loop will iterate until user enters valid number.
                while(userInput<1 || userInput>5)
                {
                    Console.WriteLine("This is not a valid number to select options!");
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("|| Please Enter==> 1 for  Pastry: Biscotti, which costs 6$. ||");
                    Console.WriteLine("|| Please Enter==> 2 for  Pastry: Danish, which costs 7$.   ||");
                    Console.WriteLine("|| Please Enter==> 3 for  Pastry: Canolli, which costs 8$.  ||");
                    Console.WriteLine("|| Please Enter==> 4 for  Pastry: Muffin, which costs 9$.   ||");
                    Console.WriteLine("|| Please Enter==> 5 for  Pastry: Croissant, which costs 1$.||");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

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
                choiceNumber++;

            }
            string orders_and__totalCost = "List of orders:\n"+ListBreadAndPastry.PrintListBreads()+""+ListBreadAndPastry.PrintListPastries()+"\n"+
                                           "-------------------------------\n"+
                                           "|Total Price for Breads: "+ListBreadAndPastry.GetTotalPriceForBreads()+" $ |\n"+
                                           "|Total Price for Pastries: "+ListBreadAndPastry.GetTotalPriceForPastries()+" $|\n"+
                                           "-------------------------------\n"+
                                           "*****Total Final Price*****\n"+
                                           "|OverAll Total Price: "+ListBreadAndPastry.GetTotalPrice()+" $|\n"+
                                           "***************************";
            
            Console.WriteLine(orders_and__totalCost);

            Console.WriteLine("Would you like to exit  or modify your list ? "+"\n"+"Enter for Exit==> 1 "+"\n"+"Enter for Modify List==> 2");
            userInput = int.Parse(Console.ReadLine());
            while(userInput == 2)
            {
                Console.WriteLine("+-----------------------------CURRENT LIST----------------------------------------+");
                string listCurrentBreads = ListBreadAndPastry.PrintListBreads();
                string listCurrentPastries = ListBreadAndPastry.PrintListPastries();
                Console.WriteLine(listCurrentBreads);
                Console.WriteLine(listCurrentPastries);
                Console.WriteLine("Would you like to remove any breads or pastries from the list?"+"\n"+"Enter for Bread==> 1"+"\n"+"Enter for Pastry==> 3");
                userInput = int.Parse(Console.ReadLine());
                if(userInput==1)
                {
                    for(int idx = 0; idx < ListBreadAndPastry.GetSizeOfListBreads(); idx++)
                    {
                        Console.WriteLine("Enter ==> "+idx+" For Removing: "+ListBreadAndPastry.GetBreadByIndex(idx));
                    }
                    userInput = int.Parse(Console.ReadLine());
                    ListBreadAndPastry.RemoveBreadByIndex(userInput);
                }
                else if(userInput==3)
                {
                    for(int idx=0; idx<ListBreadAndPastry.GetSizeOfListPastries(); idx++)
                    {
                        Console.WriteLine("Enter ==> "+idx+" For removing: "+ListBreadAndPastry.GetPastryByIndex(idx));
                    }
                    userInput = int.Parse(Console.ReadLine());
                    ListBreadAndPastry.RemovePastryByIndex(userInput);
                }

                Console.WriteLine("Please enter 2 to continue removing items in the list or enter any number to exit: ");
                userInput = int.Parse(Console.ReadLine());

            }
            orders_and__totalCost = "List of orders:\n"+ListBreadAndPastry.PrintListBreads()+""+ListBreadAndPastry.PrintListPastries()+"\n"+
                                           "-------------------------------\n"+
                                           "|Total Price for Breads: "+ListBreadAndPastry.GetTotalPriceForBreads()+" $ |\n"+
                                           "|Total Price for Pastries: "+ListBreadAndPastry.GetTotalPriceForPastries()+" $|\n"+
                                           "-------------------------------\n"+
                                           "*****Total Final Price*****\n"+
                                           "|OverAll Total Price: "+ListBreadAndPastry.GetTotalPrice()+" $|\n"+
                                           "***************************";
            Console.WriteLine(orders_and__totalCost);
            Console.WriteLine("Thank you for your shopping!");

            
        }
    }
}