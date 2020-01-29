using System;
using System.Collections.Generic;
using Vendor.Models;
using vendor.Interfaces;


namespace Vendor.Service

{
  class VendorService

  {
    private Machine Machine { get; set; } = new Machine();
    public List<string> Messages = new List<string>();
    public void PrintMenu()
    {
      Messages.Add("---Welcome to the Vending Maching---");
      Messages.Add("Please add money and make your selection");

      foreach (var item in Machine.Items)
      {

        Messages.Add(item.GetMachineItem());

      }
      {
        Messages.Add("You currently have $" + Machine.Wallet);
        Messages.Add("Press m to add Money then type your selection");
        Messages.Add("Press q to quit");
        Messages.Add("Press i to see your inventory");
      }
    }

    internal void AddMoney()
    {

      string input = Console.ReadLine();
      float.TryParse(input, out float m);
      Machine.Wallet += m;
      Console.Clear();

    }

    internal void ViewInventory()
    {
      for (int i = 0; i < Machine.Inventory.Count; i++)
      {
        Messages.Add($"{Machine.Inventory[i].Title}");
      }
      Messages.Add("");
      Messages.Add("Press any key to return");
    }

    internal void Purchase(string input)
    {
      for (int i = 0; i < Machine.Items.Count; i++)
      {

        if (Machine.Items[i].OrderCode == input && Machine.Items[i].Price <= Machine.Wallet)
        {
          Machine.Wallet -= Machine.Items[i].Price;
          Messages.Add("Thank you for purchasing " + Machine.Items[i].Title);
          Machine.Inventory.Add(Machine.Items[i]);

        }
        if (Machine.Items[i].OrderCode == input && Machine.Items[i].Price > Machine.Wallet)
        {
          Messages.Add("Please add more money");
        }
      }

    }
  }
}