using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCWebSite.ViewModels
{
    public class ConfRoomViewModel
    {
        [Required]
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Required]
        [Display(Name = "Building")]
        public string RoomBuilding { get; set; }
        [Required]
        [Display(Name = "Room Phone Number")]
        public string RoomPhoneNum { get; set; }
        [Required]
        [Display(Name = "A/V Capable")]
        public bool AVCapable { get; set; }
        [Required]
        [Display(Name = "Room Capacity")]
        public int RoomCapacity { get; set; }
        public string Size { get; set; }
        public bool EntrySuccess { get; set; }
        public string Message { get; set; }
    }
}
