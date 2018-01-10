using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class ContinuationEntity
    {
        public Nullable<int> SequelId { get; set; }

        public string SequelTitle { get; set; }

        public string SequelDescription { get; set; }

        public int ForumId { get; set; }

        public int SequelParentId { get; set; }

        public int SequelType { get; set; }

        public int SequelStatus { get; set; }

        public Nullable<DateTime> SequelPublishedDate { get; set; }

        public int UserId { get; set; }

        public DateTime SequelCreatedDate { get; set; }

        public Nullable<DateTime> SequelModifiedDate { get; set; }

        public int SequelModifiedBy { get; set; }
    }
}
