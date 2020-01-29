using System.Collections.Generic;
using vendor.Interfaces;

namespace Vendor.Models

{
  class Machine
  {
    public List<IPurchasable> Items { get; set; } = new List<IPurchasable>();
    public List<IPurchasable> Inventory { get; set; } = new List<IPurchasable>();
    public float Wallet = 0;


    private void Setup()
    {

      Frozen pop = new Frozen("Popcicle", 2.00f, 100, "September 2121", "a1");
      Frozen ICS = new Frozen("Ice Cream Sandwich", 3.00f, 300, "October 1995", "a2");
      Frozen fudgey = new Frozen("Fudgesicle", 4.00f, 500, "February 2020", "a3");
      Candy dots = new Candy("DOTS", 1.00f, 75, "November 2020", CandyList.Fruity, "b1");
      Candy chocy = new Candy("Hershey Bar", 1.50f, 175, "June 2020", CandyList.Chocolate, "b2");
      Candy taff = new Candy("Salt Water Taffy", 2.25f, 155, "July 2022", CandyList.Taffy, "b3");
      Candy goom = new Candy("Doublemint Gum", 1.25f, 20, "January 2024", CandyList.Gum, "b4");
      Electronics iPone = new Electronics("iPhone X", 1199, PowerSource.LightningCable, "c1");
      Electronics headphones = new Electronics("Beats by Dre", 299, PowerSource.USB_C, "c2");
      Electronics walkman = new Electronics("Sony Walkman", 9, PowerSource.C, "c3");
      Items.AddRange(new IPurchasable[] { pop, ICS, fudgey, dots, chocy, taff, goom, iPone, headphones, walkman });

    }

    public Machine()
    {
      Setup();
    }

  }

}