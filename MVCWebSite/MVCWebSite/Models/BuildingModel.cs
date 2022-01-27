using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebSite.Models
{
    public class BuildingModel
    {
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string BuildingStreet { get; set; }
        public string BuildingCity { get; set; }
        public string BuildingState { get; set; }
        public int BuildingZip { get; set; }
        public string BuildingCountry { get; set; }
        public string BuildingPhoneNum { get; set; }
        public int NumFloors { get; set; }
        public int NumConfRoom { get; set; }
        public string BuildingClass { get; set; }
        public string BuildingType { get; set; }
    }
}