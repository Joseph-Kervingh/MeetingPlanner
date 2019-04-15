using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{

    public class Agenda
    {
        public int AgendaID { get; set; }
        public int MeetingID { get; set; }
        public int HymnID { get; set; }
        public int PrayerID { get; set; }

        public Meeting Meeting { get; set; }
        public Hymn Hymn { get; set; }
        public Prayer Prayer { get; set; }
    }
}