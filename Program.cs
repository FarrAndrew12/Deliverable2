using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int partymember;

        double price;

        price = 9.99;

        double billtotal;

        double pepsiprice;

        pepsiprice = 2.00;

        string drinkpreference;

        int numberofpepsis;

        numberofpepsis = 0;
        
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for Pespi. How many people are in your group? Please, parties of 6 or lower.");

            Console.WriteLine();

            partymember = int.Parse(Console.ReadLine());

            Console.WriteLine();



        if (partymember >= 1 && partymember <= 6)
        {
            Console.WriteLine("A table for " + partymember + "! Please follow me and take a seat."); 
            
            for (int i = 1; i <= partymember; i++)
            {
                Console.WriteLine(" Alright for person " + i + ", water or Pepsi?");

                Console.WriteLine();

                drinkpreference = Console.ReadLine();

                Console.WriteLine();



                if (drinkpreference == "pepsi")
                {
                    numberofpepsis++;
                }
                else if (drinkpreference != "water")
                {
                    Console.WriteLine("Sorry bucko! We don't sell that here");

                    Console.WriteLine();
                }

            }
            billtotal = partymember * price + numberofpepsis * pepsiprice;


            Console.WriteLine();

            Console.WriteLine("Here's your bill! Total price: " + billtotal);
        } else { Console.WriteLine("Oh sorry, can only seat up to 6. Have a nice day.");
        }
            }
}
