using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomBooking.Models
{
    public class ClassroomDTO
    {
        public int ClassroomID { get; set; }
        public string ClassroomName { get; set; }

        public List<cRoomDTO> cRoomDTOs { get; set; }
    }
}