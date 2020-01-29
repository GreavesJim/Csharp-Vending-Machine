using vendor.Interfaces;

namespace Vendor.Models
{
  class Frozen : Food, IPurchasable
  {
    public Frozen(string title, float price, int kCals, string experationDate, string orderCode) : base(title, price, kCals, experationDate, orderCode)
    {

    }

    public int TemperatureF { get; set; } = 32;

    public override string GetMachineItem()
    {
      return $"{OrderCode})--{Title}----{TemperatureF}°F------${Price}";
    }
  }

}