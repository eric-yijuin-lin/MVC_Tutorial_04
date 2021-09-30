using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Tutorial_04.Models
{
    public partial class TblMeetingAppointment
    {
        public int MeetingId { get; set; }
        public string Subject { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public int AttendeeCount { get; set; }
        public int BookedBy { get; set; }
    }
}
