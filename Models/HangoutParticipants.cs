using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace BeltExam
{
    public class HangoutParticipants
    {
        [Key]
        public int HangoutParticipantId { get; set; }

        [Required]
        public int? HangoutId { get; set; }
        public Hangout Hangout { get; set; }

        [Required]
        public int? ParticipantId { get; set; }
        public User Participant { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}