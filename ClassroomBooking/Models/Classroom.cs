using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassroomBooking.Models
{
    public class Classroom
    {
        private ICollection<cRoom> _cRooms;

        public Classroom()
        {
            _cRooms = new List<cRoom>();
        }

        public int ClassroomID { get; set; }
        public string ClassroomName { get; set; }




        public virtual ICollection<cRoom> Docs
        {
            get { return _cRooms; }
            set { _cRooms = value; }
        }
    }
}