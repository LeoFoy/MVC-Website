using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTOs
{
    public class ConfRoomInfoDTO
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string RoomBuilding { get; set; }
        public string RoomPhoneNum { get; set; }
        public bool AVCapable { get; set; }
        public int RoomCapacity { get; set; }
    }
}
