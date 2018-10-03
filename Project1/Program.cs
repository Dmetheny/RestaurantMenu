using System;
using static System.Console;

namespace Project1
{
    class Program
    {
        static void Main()
        {
          // Declaring Variables
          const string FRUIT_SALAD = "Fruit Salad";
          const string PASTA_SALAD = "Pasta Salad";
          const string SMOOTHIE = "Smoothie";
          const string FRUIT_JUICE = "Fruit Juice";
          const string CUPCAKE = "Cupcake";
          const string SHORTCAKE = "Shortcake";

          const double FRUIT_SALAD_PRICE = 9.95;
          const double PASTA_SALAD_PRICE = 12.00;
          const double SMOOTHIE_PRICE = 4.95;
          const double FRUIT_JUICE_PRICE = 3.95;
          const double CUPCAKE_PRICE = 3.00;
          const double SHORTCAKE_PRICE = 6.00;

          const double TAX_RATE = 0.095;

          int numberOfItemOne, numberOfItemTwo, numberOfItemThree, 
              numberOfItemFour, numberOfItemFive, numberOfItemSix;
          double subTotalCosts, tax, totalCosts;

         // Display Menu Items To User
         WriteLine("********************************** Menu **********************************");
         WriteLine(FRUIT_SALAD + " : " + "{0:C}", FRUIT_SALAD_PRICE);
         WriteLine(PASTA_SALAD + " : " + "{0:C}", PASTA_SALAD_PRICE);
         WriteLine(SMOOTHIE + " : " + "{0:C}", SMOOTHIE_PRICE);
         WriteLine(FRUIT_JUICE + " : " + "{0:C}", FRUIT_JUICE_PRICE);
         WriteLine(CUPCAKE + " : " + "{0:C}", CUPCAKE_PRICE);
         WriteLine(SHORTCAKE + " : " + "{0:C}", SHORTCAKE_PRICE);
         WriteLine("**************************************************************************");
            
         // Customer Enters Order
         WriteLine();
         WriteLine("**************************** Enter Your Order ****************************");  
         WriteLine("How many " + FRUIT_SALAD + "(s)" + " --- " + "{0:C}" + "?", FRUIT_SALAD_PRICE);
         numberOfItemOne = Convert.ToInt32(ReadLine());
         WriteLine("How many " + PASTA_SALAD + "(s)" + " --- " + "{0:C}" + " ?", PASTA_SALAD_PRICE);
         numberOfItemTwo = Convert.ToInt32(ReadLine());
         WriteLine("How many " + SMOOTHIE +  "(s)" + " --- " + "{0:C}" + " ?", SMOOTHIE_PRICE);
         numberOfItemThree = Convert.ToInt32(ReadLine());
         WriteLine("How many " + FRUIT_JUICE + "(s)" + " --- " + "{0:C}" + " ?", FRUIT_JUICE_PRICE);
         numberOfItemFour = Convert.ToInt32(ReadLine());
         WriteLine("How many " + CUPCAKE + "(s)" + " --- " + "{0:C}" + " ?", CUPCAKE_PRICE);
         numberOfItemFive = Convert.ToInt32(ReadLine());
         WriteLine("How many " + SHORTCAKE + "(s)" + " --- " + "{0:C}" + " ?", SHORTCAKE_PRICE);
         numberOfItemSix = Convert.ToInt32(ReadLine());
         WriteLine("*************************************************************************");

         // Cost Calculation
         subTotalCosts = numberOfItemOne * FRUIT_SALAD_PRICE + numberOfItemTwo * PASTA_SALAD_PRICE
         + numberOfItemThree * SMOOTHIE_PRICE + numberOfItemFour * FRUIT_JUICE_PRICE + numberOfItemFive
         * CUPCAKE_PRICE + numberOfItemSix * SHORTCAKE_PRICE;
         tax = TAX_RATE * subTotalCosts;
         totalCosts = subTotalCosts + tax;
            
         // Display Costs
         WriteLine();
         WriteLine("Sub Total Cost: {0:C} ", subTotalCosts);
         WriteLine("Tax: {0:C} ", tax);
         WriteLine("Total Cost: {0:C} ", totalCosts);
         WriteLine();
         WriteLine("Thank You!");
         ReadKey();

        }
    }
}