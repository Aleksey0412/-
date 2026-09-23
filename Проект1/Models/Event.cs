using System;

namespace BlockchainConferenceApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Direction { get; set; }
        public string City { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int OrganizerId { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
    }
}