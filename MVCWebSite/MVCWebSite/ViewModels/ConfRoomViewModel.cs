using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCWebSite.ViewModels
{
    public class ConfRoomViewModel
    {
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Display(Name = "Building")]
        public string RoomBuilding { get; set; }
        [Display(Name = "Room Phone Number")]
        public string RoomPhoneNum { get; set; }
        [Display(Name = "A/V Capable")]
        public bool AVCapable { get; set; }
        [Display(Name = "Room Capacity")]
        public int RoomCapacity { get; set; }
    }
}
