using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Prayer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrayerID { get; set; }
        public string OpeningP { get; set; }
        public string SacramentP { get; set; }
        public string ClosingP { get; set; }


        public ICollection<Agenda> Agendas { get; set; }
    }
}
