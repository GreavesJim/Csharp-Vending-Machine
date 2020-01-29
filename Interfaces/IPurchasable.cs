namespace vendor.Interfaces
{
  interface IPurchasable
  {
    string Title { get; set; }
    float Price { get; set; }

    string OrderCode { get; set; }


    string GetMachineItem();


  }

}

