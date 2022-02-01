using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebSite.ViewModels;
using DataLibrary.DTOs;
using DataLibrary.Repositories;
using MVCWebSite.Models;


namespace MVCWebSite.BusinessLogic
{
    public class BuildingBL
    {
        public string DetermineClass(string buildingCity)
        {
            string BuildingClass = string.Empty;

            if (buildingCity.ToLower() == "louisville")
            {
                BuildingClass = "campus";
            }
            else
            {
                BuildingClass = "satellite office";
            }

            return BuildingClass;
        }

        public string DetermineType(int numFloors)
        {
            string type = string.Empty;

            if (numFloors <= 5)
            {
                type = "standard building";
            }
            else if (numFloors > 5)
            {
                type = "tower";
            }

            return type;
        }

        public List<BuildingModel> GetBuildings()
        {
            List<BuildingModel> buildingModels = new List<BuildingModel>();
            BuildingRepo buildingRepo = new BuildingRepo();
            List<BuildingInfoDTO> buildingInfoDTOs = buildingRepo.GetAllBuildings();

            List<BuildingModel> buildingModelList = ConvertBuildingToModels(buildingInfoDTOs);

            return buildingModelList;
        }

        private List<BuildingModel> ConvertBuildingToModels(List<BuildingInfoDTO> bi)
        {
            List<BuildingModel> buildingModelList = new List<BuildingModel>();

            foreach (BuildingInfoDTO bd in bi)
            {
                BuildingModel bm = new BuildingModel();
                bm.BuildingName = bd.BuildingName;
                bm.BuildingStreet = bd.BuildingStreet;
                bm.BuildingCity = bd.BuildingCity;
                bm.BuildingState = bd.BuildingState;
                bm.BuildingZip = Convert.ToInt32(bd.BuildingZip);
                bm.BuildingCountry = bd.BuildingCountry;
                bm.BuildingPhoneNum = bd.PhoneNum;
                bm.NumFloors = Convert.ToInt32(bd.NumFloors);
                bm.NumConfRoom = Convert.ToInt32(bd.NumConfRoom);

                buildingModelList.Add(bm);
            }
            return buildingModelList;
        }
    }
}