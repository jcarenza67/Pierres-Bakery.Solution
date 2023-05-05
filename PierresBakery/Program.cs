using System;
using System.Collections;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.Title = "Pierre's Bakery";
      string title = @" 
                                                              (                                                                        
        (  (           (                           *   )      )\ )                          (         (            )                   
        )\))(   '   (  )\             )      (   ` )  /(     (()/( (     (   (    (      (  )\      ( )\     )  ( /(    (   (    (     
        ((_)()\ )   ))\((_) (   (     (      ))\   ( )(_))(    /(_)))\   ))\  )(   )(    ))\((_)(    )((_) ( /(  )\())  ))\  )(   )\ ) 
        _(())\_)() /((_)_   )\  )\    )\  ' /((_) (_(_()) )\  (_)) ((_) /((_)(()\ (()\  /((_)   )\  ((_)_  )(_))((_)\  /((_)(()\ (()/( 
        \ \((_)/ /(_)) | | ((_)((_) _((_)) (_))   |_   _|((_) | _ \ (_)(_))   ((_) ((_)(_))    ((_)  | _ )((_)_ | |(_)(_))   ((_) )(_))
         \ \/\/ / / -_)| |/ _|/ _ \| '  \()/ -_)    | | / _ \ |  _/ | |/ -_) | '_|| '_|/ -_)   (_-<  | _ \/ _` || / / / -_) | '_|| || |
          \_/\_/  \___||_|\__|\___/|_|_|_| \___|    |_| \___/ |_|   |_|\___| |_|  |_|  \___|   /__/  |___/\__,_||_\_\ \___| |_|   \_, |
                                                                                                                                  |__/  
      ";

      Console.WriteLine(title);
      Console.WriteLine("Breads are $5 each, and we are having a buy 2 get 1 free sale!");
      Console.WriteLine("Pastries are $2 each, and we are having a buy 3 get 1 free sale!");


      Bread sourdough = new Bread("sourdough", 5);
      Bread wheat = new Bread("wheat", 5);
      Bread rye = new Bread("rye", 5);

      Pastry croissant = new Pastry("croissant", 2);
      Pastry danish = new Pastry("danish", 2);
      Pastry bearclaw = new Pastry("bearclaw", 2);

      string orderType = "";
      bool validInputType = false;
      while (!validInputType)
      {
        Console.WriteLine("Would you like bread, pastries, or both? (Enter 'bread', 'pastries', or 'both')");
        orderType = Console.ReadLine().ToLower();
        if (orderType == "bread" || orderType == "pastries" || orderType == "both")
        {
          validInputType = true;
        }
        else
        {
          Console.WriteLine("Invalid input. Please enter 'bread', 'pastries', or 'both'.");
        }
      }

      int breadTotal = 0;
      int pastryTotal = 0;

      if (orderType == "bread" || orderType == "both")
      {
        bool validInput = false;
        int breadOrderAmount = 0;

        while (!validInput)
        {
          Console.WriteLine("Which type of bread would you like? (Enter 'sourdough', 'wheat', or 'rye')");
          string breadType = Console.ReadLine().ToLower();

          Bread selectedBread = null;
          switch (breadType)
          {
            case "sourdough":
              selectedBread = sourdough;
              break;
            case "wheat":
              selectedBread = wheat;
              break;
            case "rye":
              selectedBread = rye;
              break;
            default:
              Console.WriteLine("Invalid input. Please enter 'sourdough', 'wheat', or 'rye'.");
              continue;
          }

          Console.WriteLine("How many loaves of " + selectedBread.BreadType + " bread would you like?");
          string input = Console.ReadLine();

          if (int.TryParse(input, out breadOrderAmount))
          {
            if (breadOrderAmount >= 0)
            {
              validInput = true;
              breadTotal = selectedBread.BreadOrder(breadOrderAmount);
            }
            else
            {
              Console.WriteLine("Invalid input. Please enter a positive number.");
            }
          }
          else
          {
            Console.WriteLine("Invalid input. Please enter a number.");
          }
        }
      }

      if (orderType == "pastries" || orderType == "both")
      {
        bool validInput = false;
        int pastryOrderAmount = 0;
        while (!validInput)
        {
          Console.WriteLine("What type of pastry would you like? (Enter 'croissant', 'danish', or 'bearclaw')");
          string pastryType = Console.ReadLine().ToLower();

          Pastry selectedPastry = null;

          switch (pastryType)
          {
            case "croissant":
              selectedPastry = croissant;
              break;
            case "danish":
              selectedPastry = danish;
              break;
            case "bearclaw":
              selectedPastry = bearclaw;
              break;
            default:
              Console.WriteLine("Invalid input. Please enter 'croissant', 'danish', or 'bearclaw'.");
              continue;
          }

          Console.WriteLine("How many " + selectedPastry.PastryType + "'s would you like?");
          string input = Console.ReadLine();

          if (int.TryParse(input, out pastryOrderAmount))
          {
            if (pastryOrderAmount >= 0)
            {
              validInput = true;
              pastryTotal = selectedPastry.PastryOrder(pastryOrderAmount);
            }
            else
            {
              Console.WriteLine("Invalid input. Please enter a positive number.");
            } 
          }
          else
          {
            Console.WriteLine("Invalid input. Please enter a number.");
          }
        }
      }

      int orderTotal = breadTotal + pastryTotal;

      if (breadTotal > 0)
      {
        Console.WriteLine("Your bread total is $" + breadTotal + ".");
      }

      if (pastryTotal > 0)
      {
        Console.WriteLine("Your pastry total is $" + pastryTotal + ".");
      }

      Console.WriteLine("Your order total is $" + orderTotal + ".");
    }
  }
}