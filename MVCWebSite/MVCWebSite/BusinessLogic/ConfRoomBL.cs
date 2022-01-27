using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}