using System;
using System.Collections.Generic;
using System.Text;

#region organizer profile

namespace EventHub
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Biography { get; set; }

        public string? Website { get; set; }

        public string? Logo { get; set; }

        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; }
    }
}

#endregion
