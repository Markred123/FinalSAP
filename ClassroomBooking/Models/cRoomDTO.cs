using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomBooking.Models
{
    public class cRoomDTO
    {
        public int cRoomID { get; set; }
        public string studentName { get; set; }
        public string studentEmail { get; set; }

        public int studentPhone { get; set; }
        public DateTime cRoomDate { get; set; }
        public List<ClassroomDTO> Classrooms { get; set; }
    }
}