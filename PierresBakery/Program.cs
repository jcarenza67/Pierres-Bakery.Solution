using System;
using System.Collections;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        Console.Title = "Pierre's Bakery";
        string title = @" 
          ██     ██ ███████ ██       ██████  ██████  ███    ███ ███████     ████████  ██████      ██████  ██ ███████ ██████  ██████  ███████ ███████     ██████   █████  ██   ██ ███████ ██████  ██    ██ ██ 
          ██     ██ ██      ██      ██      ██    ██ ████  ████ ██             ██    ██    ██     ██   ██ ██ ██      ██   ██ ██   ██ ██      ██          ██   ██ ██   ██ ██  ██  ██      ██   ██  ██  ██  ██ 
          ██  █  ██ █████   ██      ██      ██    ██ ██ ████ ██ █████          ██    ██    ██     ██████  ██ █████   ██████  ██████  █████   ███████     ██████  ███████ █████   █████   ██████    ████   ██ 
          ██ ███ ██ ██      ██      ██      ██    ██ ██  ██  ██ ██             ██    ██    ██     ██      ██ ██      ██   ██ ██   ██ ██           ██     ██   ██ ██   ██ ██  ██  ██      ██   ██    ██       
           ███ ███  ███████ ███████  ██████  ██████  ██      ██ ███████        ██     ██████      ██      ██ ███████ ██   ██ ██   ██ ███████ ███████     ██████  ██   ██ ██   ██ ███████ ██   ██    ██    ██ 
                                                                                                                                                                                                              
                                                                                                                                                                                                            
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

        decimal fullTotal = 0;

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

        fullTotal = breadTotal + pastryTotal;

        bool validInputTip = false;
        decimal tipAmount = 0;
        decimal fullTotalWithTip = fullTotal;

        while (!validInputTip)
        {
          Console.WriteLine("Would you like to leave a tip? (Enter 'yes' or 'no')");
          string tipInput = Console.ReadLine().ToLower();

          if (tipInput == "yes")
          {
            bool validInputPercentage = false;
            decimal percentage = 0;

            while (!validInputPercentage)
            {
              Console.WriteLine("How much would you like to tip? (Enter a % between 0 and 100)");
              string inputPercent = Console.ReadLine();

              if (decimal.TryParse(inputPercent, out percentage))
              {
                if (percentage >= 0 && percentage <= 100)
                {
                  validInputPercentage = true;
                  fullTotal = breadTotal + pastryTotal;
                  Tip tip = new Tip(percentage, fullTotal);
                  tipAmount = tip.Amount;
                  fullTotalWithTip = Math.Round(fullTotal + tipAmount, 2);
                }
                else
                {
                  Console.WriteLine("Invalid input. Please enter a number between 0% and 100%.");
                }
              }
              else
              {
                Console.WriteLine("Invalid input. Please enter a number.");
              }
            }

            validInputTip = true;

          }
          else if (tipInput == "no")
          {
            validInputTip = true;
          }
          else
          {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
          }
        }
        

        if (breadTotal > 0)
        {
          Console.WriteLine("Your bread total is $" + breadTotal + ".");
        }

        if (pastryTotal > 0)
        {
          Console.WriteLine("Your pastry total is $" + pastryTotal + ".");
        }

        if (tipAmount > 0)
        {
          Console.WriteLine("Your order total is $" + fullTotalWithTip + " with the $" + tipAmount + " tip included.");
        }
        else
        {
        Console.WriteLine("Your order total is $" + fullTotal + ".");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("An unexpected error occured: " + ex.Message);
      }
    }
  }
}