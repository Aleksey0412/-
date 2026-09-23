using System;

namespace BlockchainConferenceApp.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int EventId { get; set; }
        public string ActivityName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string JuryNames { get; set; } // ФИО жюри через запятую
    }
}