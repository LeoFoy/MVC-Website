using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebSite.Models;
using MVCWebSite.ViewModels;

namespace MVCWebSite.Controllers
{
    public class ConfRoomController : Controller
    {
        // GET: ConfRoom
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListConfRooms()
        {
            List<ConfRoomModels> confRoomModels = CreateData();

            List<ConfRoomViewModel> confRoomViewModels = new List<ConfRoomViewModel>();
            foreach (ConfRoomModels confRoomModel in confRoomModels)
            {
                ConfRoomViewModel confRoomViewModel = ConvertToViewModel(confRoomModel);
                confRoomViewModels.Add(confRoomViewModel);
            }

            return View(confRoomViewModels);
        }

        private List<ConfRoomModels> CreateData()
        {
            List<ConfRoomModels> confRoomModels = new List<ConfRoomModels>();
            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 1,
                RoomName = "The Room",
                RoomBuilding = "Louisville",
                RoomPhoneNum = "555-5555",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 2,
                RoomName = "Fun House",
                RoomBuilding = "Louisville",
                RoomPhoneNum = "555-6666",
                AVCapable = false,
                RoomCapacity = 20
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 3,
                RoomName = "Epic Palace",
                RoomBuilding = "Louisville",
                RoomPhoneNum = "555-7777",
                AVCapable = true,
                RoomCapacity = 5
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 4,
                RoomName = "Hangout Spot",
                RoomBuilding = "Louisville",
                RoomPhoneNum = "555-8888",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 5,
                RoomName = "Home Sweet Home",
                RoomBuilding = "Chicago",
                RoomPhoneNum = "111-2222",
                AVCapable = true,
                RoomCapacity = 10
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 6,
                RoomName = "Closet",
                RoomBuilding = "Chicago",
                RoomPhoneNum = "111-3333",
                AVCapable = false,
                RoomCapacity = 3
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 7,
                RoomName = "Guild Hall",
                RoomBuilding = "Chicago",
                RoomPhoneNum = "111-4444",
                AVCapable = false,
                RoomCapacity = 30
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 8,
                RoomName = "The Vault",
                RoomBuilding = "Chicago",
                RoomPhoneNum = "111-5555",
                AVCapable = true,
                RoomCapacity = 6
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 9,
                RoomName = "Hall of the Mighty",
                RoomBuilding = "Denver",
                RoomPhoneNum = "777-1111",
                AVCapable = true,
                RoomCapacity = 20
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 10,
                RoomName = "Conference Room",
                RoomBuilding = "Denver",
                RoomPhoneNum = "777-2222",
                AVCapable = false,
                RoomCapacity = 8
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 11,
                RoomName = "The Place to do Stuff",
                RoomBuilding = "Denver",
                RoomPhoneNum = "777-3333",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 12,
                RoomName = "The Place to talk about Things",
                RoomBuilding = "Denver",
                RoomPhoneNum = "777-4444",
                AVCapable = true,
                RoomCapacity = 10
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 13,
                RoomName = "The 3rd Room",
                RoomBuilding = "Duluth",
                RoomPhoneNum = "999-6666",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 14,
                RoomName = "The 4th Room",
                RoomBuilding = "Duluth",
                RoomPhoneNum = "999-7777",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 15,
                RoomName = "The 2nd 3rd Room",
                RoomBuilding = "Duluth",
                RoomPhoneNum = "999-8888",
                AVCapable = false,
                RoomCapacity = 5
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 16,
                RoomName = "The 4th 3rd Room",
                RoomBuilding = "Duluth",
                RoomPhoneNum = "999-9999",
                AVCapable = true,
                RoomCapacity = 14
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 17,
                RoomName = "Castle Upon Mount Igni",
                RoomBuilding = "Lehi",
                RoomPhoneNum = "333-3333",
                AVCapable = true,
                RoomCapacity = 100
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 18,
                RoomName = "CIA Conference Room",
                RoomBuilding = "Lehi",
                RoomPhoneNum = "333-4444",
                AVCapable = true,
                RoomCapacity = 7
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 19,
                RoomName = "Planning Room",
                RoomBuilding = "Lehi",
                RoomPhoneNum = "333-5555",
                AVCapable = true,
                RoomCapacity = 10
            });

            confRoomModels.Add(new ConfRoomModels
            {
                RoomID = 20,
                RoomName = "Secret Evil Planning Room",
                RoomBuilding = "Lehi",
                RoomPhoneNum = "333-6666",
                AVCapable = false,
                RoomCapacity = 12
            });

            return confRoomModels;
        }
        private ConfRoomViewModel ConvertToViewModel(ConfRoomModels cm)
        {
            ConfRoomViewModel cvm = new ConfRoomViewModel();
            cvm.RoomID = cm.RoomID;
            cvm.RoomName = cm.RoomName;
            cvm.RoomBuilding = cm.RoomBuilding;
            cvm.RoomPhoneNum = cm.RoomPhoneNum;
            cvm.AVCapable = cm.AVCapable;
            cvm.RoomCapacity = cm.RoomCapacity;

            return cvm;
        }
    }
}