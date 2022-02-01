using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTOs
{
    public class BuildingInfoDTO
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string BuildingStreet { get; set; }
        public string BuildingCity { get; set; }
        public string BuildingState { get; set; }
        public string BuildingZip { get; set; }
        public string BuildingCountry { get; set; }
        public string PhoneNum { get; set; }
        public int NumFloors { get; set; }
        public int NumConfRoom { get; set; }
    }
}
