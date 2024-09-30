using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using SIMS.BL;

namespace SIMS.ViewModels
{
    public class AttendanceModel
    {
        private Attendance _attendance;

        #region Props

        [Display(Name = "I D")]
        //[Required]
        public int Id { get { return _attendance.Id; } set { _attendance.Id = value; } }

        [Display(Name = "Employee Name")]
        //[Required]
        public int Staffid { get { return _attendance.Staffid; } set { _attendance.Staffid = value; } }

        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get { return _attendance.Date; } set { _attendance.Date = value; } }

        [Display(Name = "Entering Time")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? Enteringtime { get { return _attendance.Enteringtime; } set { _attendance.Enteringtime = value; } }

        [Display(Name = "Leaving Time")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? Leavingtime { get { return _attendance.Leavingtime; } set { _attendance.Leavingtime = value; } }


        [Display(Name = "Department")]
        //	[Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Department { get { return _attendance.Department; } set { _attendance.Department = value; } }

        [Display(Name = "Is Present")]
        //[Required]
        public string Status { get { return _attendance.Status; } set { _attendance.Status = value; } }

        [Display(Name = "Reason")]
        //[Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Reason { get { return _attendance.Reason; } set { _attendance.Reason = value; } }

        public Attendance Attendance { get { return _attendance; } set { _attendance = value; } }

        #endregion //Props

        #region CTOR

        public AttendanceModel()
        {
            _attendance = new Attendance();
        }

        public AttendanceModel(Attendance attendance)
        {
            _attendance = attendance;
        }

        #endregion //CTOR

    }
}
