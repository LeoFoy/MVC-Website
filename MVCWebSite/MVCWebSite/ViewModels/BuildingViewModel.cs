using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCWebSite.ViewModels
{
    public class BuildingViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string BuildingName { get; set; }
        [Required]
        [Display(Name = "Street")]
        public string BuildingStreet { get; set; }
        [Required]
        [Display(Name = "City")]
        public string BuildingCity { get; set; }
        [Required]
        [Display(Name = "State")]
        public string BuildingState { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public int BuildingZip { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string BuildingCountry { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string BuildingPhoneNum { get; set; }
        [Required]
        [Display(Name = "Number of Floors")]
        public int NumFloors { get; set; }
        [Required]
        [Display(Name = "Number of Conference Rooms")]
        public int NumConfRoom { get; set; }
        public string BuildingClass { get; set; }
        public string BuildingType { get; set; }
        public bool EntrySuccess { get; set; }
        public string Message { get; set; }
    }
}