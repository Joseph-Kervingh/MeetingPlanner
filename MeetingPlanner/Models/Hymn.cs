using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Hymn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HymnID { get; set; }
        public string Opening { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Sacrament Hymn")]
        public string Interlude { get; set; }
        public string Closing { get; set; }


        public ICollection<Agenda> Agendas { get; set; }
    }
}