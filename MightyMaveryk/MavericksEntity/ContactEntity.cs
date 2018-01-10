using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class ContactEntity
    {
        public string Name { get; set; }

        public string EMail { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool NotifyMe { get; set; }

        public DateTime ContactDate { get; set; }

        public bool IsReplied { get; set; }

        public Nullable<DateTime> RepliedDate { get; set; }
    }
}
