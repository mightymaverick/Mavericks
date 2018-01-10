using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class TagEntity
    {
        public Nullable<int> TagId { get; set; }

        public string TagName { get; set; }

        /// <summary>
        /// Blog or Forum or Media
        /// </summary>
        public int TagType { get; set; }

        public Nullable<int> TagForumId { get; set; }

        public Nullable<int> TagMediaId { get; set; }

        public Nullable<int> TagBlogId { get; set; }

        public int TagCreatedBy { get; set; }

        public DateTime TagCreatedDate { get; set; }

        public Nullable<int> TagModifiedBy { get; set; }

        public Nullable<DateTime> TagModifiedDate { get; set; }
    }
}
