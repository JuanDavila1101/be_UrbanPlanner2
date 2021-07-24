
using System;
using System.Collections.Generic;

namespace be_UrbanPlanner2
{
  class City
  {
    public string CityName { get; set; }
    public string CityMayor { get; set; }
    public int CityYearStablished { get; } = DateTime.Now.Year;
    public List<Building> ListOfBuildings { get; } = new List<Building>();

    public City(string cityName, 
                string cityMayor)
    {
      CityName = cityName;
      CityMayor = cityMayor;
    }


    public void AddBuildingTOTheCity(Building building)
    {
      ListOfBuildings.Add(building);
    }


  }
}
