using vendor.Interfaces;

namespace Vendor.Models
{
  class Electronics : IPurchasable

  {

    public string Title { get; set; }
    public float Price { get; set; }

    public string OrderCode { get; set; }
    public PowerSource PowerSource { get; set; }

    public Electronics(string title, float price, PowerSource powerSource, string orderCode)
    {
      Title = title;
      Price = price;
      PowerSource = powerSource;
      OrderCode = orderCode;
    }
    public string GetMachineItem()
    {
      return $"{OrderCode})--{Title}---Needs: {PowerSource}------${Price}";
    }

  }
  enum PowerSource
  {
    AA,
    AAA,
    D,
    C,
    LightningCable,
    None,
    USB_C

  }

}