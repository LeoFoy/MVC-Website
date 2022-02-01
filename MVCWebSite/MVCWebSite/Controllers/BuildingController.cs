using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebSite.Models;
using MVCWebSite.ViewModels;
using MVCWebSite.BusinessLogic;

namespace MVCWebSite.Controllers
{
    public class BuildingController : Controller
    {
        // GET: Building
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EnterBuildingInfo()
        {
            return View();
        }

        public ActionResult ShowBuildingDetails()
        {
            BuildingBL buildingBL = new BuildingBL();
            List<BuildingModel> buildingModel = buildingBL.GetBuildings();

            List<BuildingViewModel> buildingViewModels = ConvertBMToShowModel(buildingModel);

            return View(buildingViewModels);
        }
        public ActionResult SaveBuildingInfo(BuildingViewModel bvm)
        {
            BuildingBL buildingBL = new BuildingBL();

            if (bvm.BuildingCity != null)
            {
                bvm.BuildingClass = buildingBL.DetermineClass(bvm.BuildingCity);
            }
            if (bvm.NumFloors != 0)
            {
                bvm.BuildingType = buildingBL.DetermineType(bvm.NumFloors);
            }

            bvm.EntrySuccess = false;
            if (bvm.BuildingName != null && bvm.BuildingStreet != null && bvm.BuildingCity != null && bvm.BuildingState != null && bvm.BuildingZip != 0 && bvm.BuildingCountry != null &&
                bvm.BuildingPhoneNum != null && bvm.NumFloors != 0 && bvm.NumConfRoom != 0)
            {
                BuildingModel buildingModel = ConvertToModel(bvm);
                bvm.EntrySuccess = true;
            }
            else
            {
                bvm.Message = "Please provide info for: Name, Street, City, State, Zip Code, Country, Phone Number, Number of Floors, and Number of Conference Rooms";
            }
            return View("EnterBuildingInfo", bvm);
        }





        private BuildingModel ConvertToModel(BuildingViewModel bvm)
        {
            BuildingModel bm = new BuildingModel();
            bm.BuildingName = bvm.BuildingName;
            bm.BuildingStreet = bvm.BuildingStreet;
            bm.BuildingCity = bvm.BuildingCity;
            bm.BuildingState = bvm.BuildingState;
            bm.BuildingZip = bvm.BuildingZip;
            bm.BuildingCountry = bvm.BuildingCountry;
            bm.BuildingPhoneNum = bvm.BuildingPhoneNum;
            bm.NumFloors = bvm.NumFloors;
            bm.NumConfRoom = bvm.NumConfRoom;

            return bm;
        }
        private BuildingViewModel ConvertToViewModel(BuildingModel bm)
        {
            BuildingViewModel bvm = new BuildingViewModel();
            bvm.BuildingName = bm.BuildingName;
            bvm.BuildingStreet = bm.BuildingStreet;
            bvm.BuildingCity = bm.BuildingCity;
            bvm.BuildingState = bm.BuildingState;
            bvm.BuildingZip = bm.BuildingZip;
            bvm.BuildingCountry = bm.BuildingCountry;
            bvm.BuildingPhoneNum = bm.BuildingPhoneNum;
            bvm.NumFloors = bm.NumFloors;
            bvm.NumConfRoom = bm.NumConfRoom;

            return bvm;
        }

        private List<BuildingViewModel> ConvertBMToShowModel(List<BuildingModel> buildingModels)
        {
            List<BuildingViewModel> buildingViewModel = new List<BuildingViewModel>();

            foreach (BuildingModel bm in buildingModels)
            {
                BuildingViewModel bvm = new BuildingViewModel();
                bvm.BuildingName = bm.BuildingName;
                bvm.BuildingStreet = bm.BuildingStreet;
                bvm.BuildingCity = bm.BuildingCity;
                bvm.BuildingState = bm.BuildingState;
                bvm.BuildingZip = bm.BuildingZip;
                bvm.BuildingCountry = bm.BuildingCountry;
                bvm.BuildingPhoneNum = bm.BuildingPhoneNum;
                bvm.NumFloors = bm.NumFloors;
                bvm.NumConfRoom = bm.NumConfRoom;

                buildingViewModel.Add(bvm);

            }

            return buildingViewModel;
        }
    }
}
