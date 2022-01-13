using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebSite.Models
{
    public class ConfRoomModels
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomBuilding { get; set; }
        public string RoomPhoneNum { get; set; }
        public bool AVCapable { get; set; }
        public int RoomCapacity { get; set; }
    }
}