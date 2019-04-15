using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [StringLength(50)]
        [Required]
        public string Conductor { get; set; }

        
        public ICollection<Agenda> Agendas { get; set; }
        
    }
}