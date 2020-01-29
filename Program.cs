using System;
using Vendor.Controllers;

namespace vendor
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      VendorController v = new VendorController();
      v.Run();
    }
  }
}
