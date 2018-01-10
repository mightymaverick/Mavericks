using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class EventsEntity
    {
        public Nullable<int> EventId { get; set; }

        public int EventOwnerId { get; set; }

        /// <summary>
        /// Birtyday, Anniversary, Death Anniversary, etc
        /// </summary>
        public int EventType { get; set; }

        public DateTime EventDate { get; set; }

        /// <summary>
        /// For setting whether the event is Private or Public
        /// </summary>
        public int EventAccess { get; set; }

        public bool IsReminderSet { get; set; }

        /// <summary>
        /// Phone, Greeting Card, E-Mail, etc
        /// </summary>
        public int ReminderType { get; set; }

        public DateTime ReminderTime { get; set; }
                
        public int EventCreatedBy { get; set; }

        public DateTime EventCreatedDate { get; set; }

        public Nullable<int> EventModifiedBy { get; set; }

        public Nullable<DateTime> EventModifiedDate { get; set; }
    }
}
