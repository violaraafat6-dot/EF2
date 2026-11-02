using System;
using System.Collections.Generic;
using System.Text;

#region badge

namespace EventHub
{
    public class Badge
    {
        public int Id { get; set; }

        public DateTime IssuedDate { get; set; }

        public string Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }
}

#endregion