using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebSite.Models;
using MVCWebSite.ViewModels;

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

        public ActionResult SaveBuildingInfo(BuildingViewModel bvm)
        {

            BuildingModel buildingModel = ConvertToModel(bvm);

            return View(bvm);
        }


        public ActionResult ListBuildings()
        {
            List<BuildingModel> buildingModel1 = CreateData();

            List<BuildingViewModel> buildingViewModels = new List<BuildingViewModel>();
            foreach (BuildingModel buildingModel in buildingModel1)
            {
                BuildingViewModel buildingViewModel = ConvertToViewModel(buildingModel);
                buildingViewModels.Add(buildingViewModel);
            }

            return View(buildingViewModels);
        }

        private List<BuildingModel> CreateData()
        {
            List<BuildingModel> buildingModels = new List<BuildingModel>();
            buildingModels.Add(new BuildingModel
            {
                BuildingID = 1,
                BuildingName = "Louisville(HQ)",
                BuildingStreet = "888 W Market St",
                BuildingCity = "Lousiville",
                BuildingState = "Kentucky",
                BuildingZip = 40247,
                BuildingCountry = "United States",
                BuildingPhoneNum = "222-4444",
                NumFloors = 13,
                NumConfRoom = 10
            });

            buildingModels.Add(new BuildingModel
            {
                BuildingID = 2,
                BuildingName = "Chicago",
                BuildingStreet = "1330 W Fulton Market #300",
                BuildingCity = "Chicago",
                BuildingState = "Illinois",
                BuildingZip = 22233,
                BuildingCountry = "United States",
                BuildingPhoneNum = "777-9955",
                NumFloors = 20,
                NumConfRoom = 16
            });

            buildingModels.Add(new BuildingModel
            {
                BuildingID = 3,
                BuildingName = "Denver",
                BuildingStreet = "7900 E Union Ave #400",
                BuildingCity = "Denver",
                BuildingState = "Colorado",
                BuildingZip = 60067,
                BuildingCountry = "United States",
                BuildingPhoneNum = "994-0454",
                NumFloors = 10,
                NumConfRoom = 10
            });

            buildingModels.Add(new BuildingModel
            {
                BuildingID = 4,
                BuildingName = "Duluth",
                BuildingStreet = "2055 Sugarloaf Cir #600",
                BuildingCity = "Duluth",
                BuildingState = "Georgia",
                BuildingZip = 56544,
                BuildingCountry = "United States",
                BuildingPhoneNum = "888-6666",
                NumFloors = 15,
                NumConfRoom = 17
            });

            buildingModels.Add(new BuildingModel
            {
                BuildingID = 5,
                BuildingName = "Lehi",
                BuildingStreet = "1650 Digital Dr",
                BuildingCity = "Lehi",
                BuildingState = "Utah",
                BuildingZip = 47658,
                BuildingCountry = "United States",
                BuildingPhoneNum = "785-0875",
                NumFloors = 20,
                NumConfRoom = 5
            });


            return buildingModels;
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
    }
}
