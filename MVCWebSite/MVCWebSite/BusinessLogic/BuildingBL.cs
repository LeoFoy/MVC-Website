using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebSite.ViewModels;


namespace MVCWebSite.BusinessLogic
{
    public class BuildingBL
    {
        public string DetermineClass(string buildingCity)
        {
            string BuildingClass = string.Empty;

            if (buildingCity.ToLower() == "louisville")
            {
                BuildingClass = "campus";
            }
            else
            {
                BuildingClass = "satellite office";
            }

            return BuildingClass;
        }

        public string DetermineType(int numFloors)
        {
            string type = string.Empty;

            if (numFloors <= 5)
            {
                type = "standard building";
            }
            else if (numFloors > 5)
            {
                type = "tower";
            }

            return type;
        }
    }
}