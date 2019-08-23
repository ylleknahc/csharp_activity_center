using System.Collections.Generic;

namespace BeltExam.Models
{
    public class HangoutUserViewModel
    {
        public User User { get; set; }
        public Hangout Hangout { get; set; }
        public List<Hangout> Hangouts { get; set; }
    }
}