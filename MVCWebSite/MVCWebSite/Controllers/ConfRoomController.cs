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
    public class ConfRoomController : Controller
    {
        // GET: ConfRoom
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EnterConfRoomInfo()
        {
            return View();
        }

        public ActionResult ShowConfRoomDetails()
        {
            ConfRoomBL confRoomBL = new ConfRoomBL();
            List<ConfRoomModels> confRoomModels = confRoomBL.GetConfRooms();

            List<ConfRoomViewModel> confRoomViewModels = ConvertRoomModelToView(confRoomModels);

            return View(confRoomViewModels);
        }
        public ActionResult SaveConfRoomInfo(ConfRoomViewModel cvm)
        {
            ConfRoomBL confRoomBL = new ConfRoomBL();
            if (cvm.RoomCapacity != 0)
            {
                cvm.Size = confRoomBL.DetermineSize(cvm.RoomCapacity);
            }


            cvm.EntrySuccess = false;
            if (cvm.RoomName != null && cvm.RoomBuilding != null && cvm.RoomPhoneNum != null && cvm.RoomCapacity != 0)
            {
                ConfRoomModels confRoomModels = ConvertToModel(cvm);
                cvm.EntrySuccess = true;
            }
            else
            {
                cvm.Message = "Please provide info for: Room Name, Building, Room Phone Number, and the Room Capacity";
            }


            return View("EnterConfRoomInfo", cvm);
        }



        private ConfRoomModels ConvertToModel(ConfRoomViewModel cvm)
        {
            ConfRoomModels cm = new ConfRoomModels();
            cm.RoomName = cvm.RoomName;
            cm.RoomBuilding = cvm.RoomBuilding;
            cm.RoomPhoneNum = cvm.RoomPhoneNum;
            cm.AVCapable = cvm.AVCapable;
            cm.RoomCapacity = cvm.RoomCapacity;

            return cm;
        }
        private ConfRoomViewModel ConvertToViewModel(ConfRoomModels cm)
        {
            ConfRoomViewModel cvm = new ConfRoomViewModel();
            cvm.RoomName = cm.RoomName;
            cvm.RoomBuilding = cm.RoomBuilding;
            cvm.RoomPhoneNum = cm.RoomPhoneNum;
            cvm.AVCapable = cm.AVCapable;
            cvm.RoomCapacity = cm.RoomCapacity;

            return cvm;
        }

        private List<ConfRoomViewModel> ConvertRoomModelToView(List<ConfRoomModels> crm)
        {
            List<ConfRoomViewModel> confRoomViewModels = new List<ConfRoomViewModel>();

            foreach (ConfRoomModels cm in crm)
            {
                ConfRoomViewModel cr = new ConfRoomViewModel();
                cr.RoomName = cm.RoomName;
                cr.RoomBuilding = cm.RoomBuilding;
                cr.RoomPhoneNum = cm.RoomPhoneNum;
                cr.AVCapable = cm.AVCapable;
                cr.RoomCapacity = cm.RoomCapacity;

                confRoomViewModels.Add(cr);
            }

            return confRoomViewModels;
        }
    }
}