using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3point2_RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> menuItems = new Dictionary<string, double>();
            menuItems["King Salmon Tartare"] = 18.00;
            menuItems["Dry Aged Steak Tartare"] = 21.00;
            menuItems["Foie Gras Torchon"] = 22.00;
            menuItems["Caesar"] = 15.00;
            menuItems["Porterhouse"] = 89.00;
            menuItems["NY Strip"] = 56.00;
            menuItems["Filet Mignon"] = 42.00;
            menuItems["Wagyu"] = 60.00;
            menuItems["Halibut"] = 46.00;
            menuItems["Spaetzel"] = 39.00;
            menuItems["Asparagus"] = 14.00;

            ArrayList itemsOrdered = new ArrayList();
            ArrayList itemsOrderedPrices = new ArrayList();

            string reference;
            bool keepGoing = true;
            bool valid_YorN = false;
            double totalAmt =0;
            //string avgPrice = (totalAmt / itemsOrdered.Count).ToString("C2");



            while (keepGoing)
            {
                //////////////////////PRINT MENU//////////////////////////////////////////////////////////////////////////
                Console.WriteLine("  ________________________________________________");
                Console.WriteLine(" |           Bougey Items               Price    |");
                Console.WriteLine("  ________________________________________________");
                foreach (KeyValuePair<string, double> kvPair in menuItems)
                {
                    Console.WriteLine($"  | {kvPair.Key,-30}  | {kvPair.Value.ToString("C2"), 10}  |");
                }
                Console.WriteLine("  ___________________________________________");
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////

                Console.WriteLine("What would you like to order?");
                string request = Console.ReadLine().ToLower();

                if (request == "1" || request.Contains("king") || request.Contains("salmon"))
                {
                    reference = "King Salmon Tartare";
                    ////////////////////// ADD ITEMS TO ARRAYLISTS ///////////////////////////////////////////////////////////
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////
                    

                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");
                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");
                            
                            //valid = false;
                        }
                    }
                    valid_YorN = false;


                }
                else if (request == "2" || request.Contains("dry") || request.Contains("aged") || request.Contains("steak"))
                {
                    reference = "Dry Aged Steak Tartare";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");


                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;


                }
                else if (request == "3" || request.Contains("foie") || request.Contains("gras") || request.Contains("torchon"))
                {
                    reference = "Foie Gras Torchon";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "4" || request.Contains("caesar"))
                {
                    reference = "Caesar";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "5" || request.Contains("porter") || request.Contains("porterhouse"))
                {
                    reference = "Porterhouse";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "6" || request.Contains("ny") || request.Contains("strip"))
                {
                    reference = "NY Strip";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "7" || request.Contains("filet") || request.Contains("mignon"))
                {
                    reference = "Filet Mignon";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "8" || request.Contains("wagyu"))
                {
                    reference = "Wagyu";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;

                }
                else if (request == "9" || request.Contains("halibut"))
                {
                    reference = "Halibut";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;
                }
                else if (request == "10" || request.Contains("spaetzel"))
                {
                    reference = "Spaetzel";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;
                }
                else if (request == "11" || request.Contains("asparagus"))
                {
                    reference = "Asparagus";
                    itemsOrdered.Add(reference);
                    itemsOrderedPrices.Add(menuItems[reference]);
                    Console.WriteLine($"You ordered {reference}, would you like to make another order? (y/n)");

                    while (!valid_YorN)
                    {
                        string continueDecision = Console.ReadLine().ToLower();

                        //Console.WriteLine($"You ordered {reference}, would you like to make another order?");
                        //Console.WriteLine("You ordered..., would you like to continue?");
                        if (continueDecision == "y")
                        {
                            valid_YorN = true;
                            keepGoing = true;

                        }
                        else if (continueDecision == "n")
                        {
                            valid_YorN = true;
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input. Please answer 'y' or 'n'.");

                            //valid = false;
                        }
                    }
                    valid_YorN = false;
                }
                else
                {
                    Console.WriteLine("That is not on the menu");
                }


            }

            Console.WriteLine("______________________________________________");
            Console.Write("             RECEIPT");
            foreach (string FE_item in itemsOrdered)
            {
                //Console.WriteLine($"{FE_item}" + "      " + menuItems[reference]);
                Console.Write($"\n\t{FE_item, -30} {menuItems[FE_item].ToString("C2"), -10}");
            }
            Console.WriteLine();
            for(int i = 0; i<itemsOrderedPrices.Count; i++)
            {
                totalAmt += (double)itemsOrderedPrices[i];
            }
            Console.WriteLine($"\n   Your total is: \t{totalAmt.ToString("C2"), -10}");

            Console.WriteLine($"   Average item price:  {(totalAmt / itemsOrdered.Count).ToString("C2"), -10}");
            Console.WriteLine("_______________________________________________");
            Console.ReadLine();
        }
    }
}


