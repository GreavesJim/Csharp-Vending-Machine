using vendor.Interfaces;

namespace Vendor.Models
{
  class Candy : Food, IPurchasable
  {
    public Candy(string title, float price, int kCals, string experationDate, CandyList candyType, string orderCode) : base(title, price, kCals, experationDate, orderCode)
    {
      CandyList CandyType = candyType;

    }

    public CandyList CandyType { get; set; }
    public override string GetMachineItem()
    {
      return $"{OrderCode})--{Title}----{CandyType}-exp.-{ExperationDate}-----${Price}";
    }



  }

  enum CandyList
  {
    Chocolate,
    Fruity,
    Gum,
    Taffy,

  }



}