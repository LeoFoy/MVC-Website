using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DataLibrary.DataAccessLayer;
using DataLibrary.DTOs;
namespace DataLibrary.Repositories
{
    public class ConfRoomRepo
    {
        public List<ConfRoomInfoDTO> GetAllConfRooms()
        {
            List<ConfRoomInfoDTO> confRoomInfoDTOs = new List<ConfRoomInfoDTO>();
            DataAccess dal = new DataAccess(ConfigurationManager.ConnectionStrings["BuildingDataConnection"].ConnectionString);

            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();
            DataTable confRoomTable = dal.PopulateTable("spGetConfRoomInfo", paramDictionary);

            foreach (DataRow row in confRoomTable.Rows)
            {
                ConfRoomInfoDTO cri = new ConfRoomInfoDTO();
                cri.RoomName = row["RoomName"].ToString();
                cri.RoomBuilding = row["RoomBuilding"].ToString();
                cri.RoomPhoneNum = row["RoomPhoneNum"].ToString();
                cri.AVCapable = Convert.ToBoolean(row["AVCapable"]);
                cri.RoomCapacity = Convert.ToInt32(row["RoomCapacity"]);

                confRoomInfoDTOs.Add(cri);
            }

            return confRoomInfoDTOs;
        }
    }
}
