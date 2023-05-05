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
      Console.WriteLine("Pastries are $2 each, and we are having a buy 3 get 1 free sale!");

      int breadPrice = 5;
      int pastryPrice = 2;

      Bread myBread = new Bread(breadPrice);
      Pastry myPastry = new Pastry(pastryPrice);

      Console.WriteLine("Would you like bread, pastries, or both? (Enter 'bread', 'pastries', or 'both')");
      string orderType = Console.ReadLine().ToLower();

      int breadTotal = 0;
      int pastryTotal = 0;

      if (orderType == "bread" || orderType == "both")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int breadOrderAmount = int.Parse(Console.ReadLine());
        breadTotal = myBread.BreadOrder(breadOrderAmount);
      }

      if (orderType == "pastries" || orderType == "both")
      {
        Console.WriteLine("How many pastries would you like?");
        int pastryOrderAmount = int.Parse(Console.ReadLine());
        pastryTotal = myPastry.PastryOrder(pastryOrderAmount);
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