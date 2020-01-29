using vendor.Interfaces;



namespace Vendor.Models
{
  abstract class Food : IPurchasable
  {
    public string Title { get; set; }
    public float Price { get; set; }

    public int KCals { get; set; }

    public string ExperationDate { get; set; }
    public string OrderCode { get; set; }

    public virtual string GetMachineItem()
    {
      return $"{OrderCode})--{Title}----({KCals}cals)------${Price}";
    }



    public Food(string title, float price, int kCals, string experationDate, string orderCode)
    {
      Title = title;
      Price = price;
      KCals = kCals;
      ExperationDate = experationDate;
      OrderCode = orderCode;
    }
  }

}