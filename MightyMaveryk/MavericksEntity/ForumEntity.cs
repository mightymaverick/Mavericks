using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    /// <summary>
    /// The class that references the content of the mavericks. It refers to an Forum/blog/album, etc
    /// </summary>
    public class ForumEntity
    {
        public Nullable<int> ForumId { get; set; }

        public Nullable<int> AuthorId { get; set; }

        public string ForumTitle { get; set; }

        public string ForumContent { get; set; }

        public string ForumType { get; set; }

        public string ForumTag { get; set; }

        public string ForumLocation { get; set; }

        public string ForumSequence { get; set; }

        public int ForumStatus { get; set; }

        public Nullable<DateTime> ForumPublishedDate { get; set; }

        public DateTime ForumCreatedDate { get; set; }

        public string ForumModifiedBy { get; set; }

        public Nullable<DateTime> ForumModifiedDate { get; set; }
    }
}
