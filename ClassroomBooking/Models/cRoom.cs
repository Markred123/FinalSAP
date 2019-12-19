using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassroomBooking.Models
{
    public class cRoom
    {
        private ICollection<Classroom> _classrooms;

        public cRoom()
        {
            _classrooms = new List<Classroom>();
        }

        public int cRoomID { get; set; }
        [Required]
        public string roomName { get; set; }
        public string studentName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string studentEmail { get; set; }

        [Required]
        public int studentPhone { get; set; }
        public DateTime cRoomDate { get; set; }
        public DateTime cRoomDateTo { get; set; }




        public virtual ICollection<Classroom> Classrooms
        {
            get { return _classrooms; }
            set { _classrooms = value; }
        }
    }
}