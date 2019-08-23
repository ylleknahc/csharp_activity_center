using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace BeltExam
{
    public class Hangout
    {
        [Key]
        public int HangoutId { get; set; }

        [Required(ErrorMessage = "Title is a required field")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [DateAttribute]
        [Display(Name = "Date")]
        public DateTime? Date { get; set; }

        [Display(Name = "Time")]
        public DateTime? Time { get; set; }

        [Display(Name = "Duration")]
        public int? Duration { get; set; }

        public string DurationType { get; set; }

        [Required(ErrorMessage = "Description is a required field")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int? CreatorId { get; set; }
        public User Creator { get; set; }


        public List<HangoutParticipants> HangoutParticipants { get; set; }
    }
}