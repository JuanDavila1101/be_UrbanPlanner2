using System;

namespace be_UrbanPlanner2
{
  class Building
  {
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume { get; private set; }

    string _designer; // will hold your name
    DateTime _dateConstructed; // when was the building created
    string _address;
    string _owner;  // this will store the name of the person that owns the building

    public Building(string address)
    {
      _designer = "onlyJuan";
      _address = address;
      Construct();
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string owner)
    {
      _owner = owner;
    }

    public void SetValue()
    {
      Volume = Width * Depth * (3 * Stories);
    }

    public void PrintBuilding()
    {
      Console.WriteLine(String.IsNullOrWhiteSpace(_address) ? "" : $"\n\nBuilding address; {_address}");
      Console.WriteLine(String.IsNullOrWhiteSpace(_designer) ? "" : $"Designed by; {_designer}");
      Console.WriteLine($"Constructed on ; {_dateConstructed}");
      Console.WriteLine(String.IsNullOrWhiteSpace(_owner) ? "" : $"Owner by: {_owner}");
      Console.WriteLine($"{Volume} cubic meters of space");
    }


  }
}
