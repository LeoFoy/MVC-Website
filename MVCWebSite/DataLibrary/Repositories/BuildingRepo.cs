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
    public class BuildingRepo
    {
        public List<BuildingInfoDTO> GetAllBuildings()
        {
            List<BuildingInfoDTO> buildingInfoDTOs = new List<BuildingInfoDTO>();
            DataAccess dal = new DataAccess(ConfigurationManager.ConnectionStrings["BuildingDataConnection"].ConnectionString);

            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            DataTable buildingTable = dal.PopulateTable("spGetBuildingInfo", paramDictionary);

            foreach (DataRow row in buildingTable.Rows)
            {
                BuildingInfoDTO bi = new BuildingInfoDTO();
                bi.BuildingName = row["BuildingName"].ToString();
                bi.BuildingStreet = row["BuildingStreet"].ToString();
                bi.BuildingCity = row["BuildingCity"].ToString();
                bi.BuildingState = row["BuildingState"].ToString();
                bi.BuildingZip = row["BuildingZip"].ToString();
                bi.BuildingCountry = row["BuildingCountry"].ToString();
                bi.PhoneNum = row["PhoneNum"].ToString();
                bi.NumFloors = Convert.ToInt32(row["NumFloors"]);
                bi.NumConfRoom = Convert.ToInt32(row["NumConfRoom"]);

                buildingInfoDTOs.Add(bi);
            }

            return buildingInfoDTOs;
        }
    }
}
