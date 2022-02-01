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
    public class ConfRoomBL
    {
        public string DetermineSize(int capacity)
        {
            string size = string.Empty;
            if (capacity > 20)
            {
                size = "large";
            }
            else if (capacity >= 11 && capacity <= 20)
            {
                size = "medium";
            }
            else if (capacity <= 10)
            {
                size = "small";
            }

            return size;
        }

        public List<ConfRoomModels> GetConfRooms()
        {
            List<ConfRoomModels> confRoomModels = new List<ConfRoomModels>();
            ConfRoomRepo confRoomRepo = new ConfRoomRepo();
            List<ConfRoomInfoDTO> confRoomInfoDTOs = confRoomRepo.GetAllConfRooms();

            List<ConfRoomModels> confRoomModelList = ConvertConfRoomToModels(confRoomInfoDTOs);

            return confRoomModelList;
        }

        private List<ConfRoomModels> ConvertConfRoomToModels(List<ConfRoomInfoDTO> cri)
        {
            List<ConfRoomModels> confRoomModelList = new List<ConfRoomModels>();

            foreach (ConfRoomInfoDTO cd in cri)
            {
                ConfRoomModels crm = new ConfRoomModels();
                crm.RoomName = cd.RoomName;
                crm.RoomBuilding = cd.RoomBuilding;
                crm.RoomPhoneNum = cd.RoomPhoneNum;
                crm.AVCapable = cd.AVCapable;
                crm.RoomCapacity = cd.RoomCapacity;

                confRoomModelList.Add(crm);
            }
            return confRoomModelList;
        }
    }
}