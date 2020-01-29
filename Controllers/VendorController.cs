using System;
using Vendor.Models;
using Vendor.Service;

namespace Vendor.Controllers
{
  class VendorController
  {
    private VendorService Service { get; set; } = new VendorService();
    private bool _running = true;

    public void Run()
    {
      Service.PrintMenu();
      while (_running)
      {
        PrintMessages();
        GetUserInput();
      }
      Console.Clear();
      System.Console.WriteLine("Bye-Bye");
    }

    private void GetUserInput()
    {
      var input = Console.ReadLine().ToLower();
      Console.Clear();

      switch (input)
      {
        case "q":
          _running = false;
          break;

        case "m":
          Console.WriteLine("How much Money would you like to add?");

          Console.Write("$:");
          Service.AddMoney();


          Service.PrintMenu();
          break;

        case "i":
          Service.ViewInventory();
          PrintMessages();
          Console.ReadKey();
          Console.Clear();
          Service.PrintMenu();
          break;

        default:
          Service.Purchase(input);

          Service.PrintMenu();
          break;
      }
    }



    private void PrintMessages()
    {
      foreach (string message in Service.Messages)
      {
        System.Console.WriteLine(message);
      }
      Service.Messages.Clear();
    }

  }

}