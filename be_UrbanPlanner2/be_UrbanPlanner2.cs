using System;

namespace be_UrbanPlanner2
{
  class be_UrbanPlanner2
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Urban Planner2");

      var metrocity = new City("Metrocity", "Megamind");

      var buildingJuan = new Building("1428 Elm Street Springwood, Ohio");
      var buildingTwo = new Building("124 Conch Street Bikini Bottom");
      var buildingThree = new Building("58N 018, 439 East District");
      var buildingFour = new Building("283 Blvd De France, Parris Island, SC 29905");



      buildingJuan.Stories = 10;
      buildingJuan.Width = 3;
      buildingJuan.Depth = 2;
      buildingJuan.SetValue();
      buildingJuan.Purchase("Freddy Krouger");
      //buildingJuan.PrintBuilding();

      buildingTwo.Stories = 11;
      buildingTwo.Width = 2;
      buildingTwo.Depth = 2;
      buildingTwo.SetValue();
      buildingTwo.Purchase("Sponge Bob");
      //buildingTwo.PrintBuilding();

      buildingThree.Stories = 10000;
      buildingThree.Width = 10;
      buildingThree.Depth = 1000;
      buildingThree.SetValue();
      buildingThree.Purchase("Goku");
      //buildingThree.PrintBuilding();

      buildingFour.Stories = 1775;
      buildingFour.Width = 1;
      buildingFour.Depth = 1;
      buildingFour.SetValue();
      buildingFour.Purchase("Chesty Pollard");
      //buildingFour.PrintBuilding();

      metrocity.AddBuildingTOTheCity(buildingJuan);
      metrocity.AddBuildingTOTheCity(buildingTwo);
      metrocity.AddBuildingTOTheCity(buildingThree);
      metrocity.AddBuildingTOTheCity(buildingFour);

      foreach(Building building in metrocity.ListOfBuildings)
      {
        building.PrintBuilding();
      }


    }
  }
}
