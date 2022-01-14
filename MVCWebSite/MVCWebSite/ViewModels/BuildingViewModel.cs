using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCWebSite.ViewModels
{
    public class BuildingViewModel
    {
        [Display(Name = "Name")]
        public string BuildingName { get; set; }
        [Display(Name = "Street")]
        public string BuildingStreet { get; set; }
        [Display(Name = "City")]
        public string BuildingCity { get; set; }
        [Display(Name = "State")]
        public string BuildingState { get; set; }
        [Display(Name = "Zip Code")]
        public int BuildingZip { get; set; }
        [Display(Name = "Country")]
        public string BuildingCountry { get; set; }
        [Display(Name = "Phone Number")]
        public string BuildingPhoneNum { get; set; }
        [Display(Name = "Number of Floors")]
        public int NumFloors { get; set; }
        [Display(Name = "Number of Conference Rooms")]
        public int NumConfRoom { get; set; }
    }
}