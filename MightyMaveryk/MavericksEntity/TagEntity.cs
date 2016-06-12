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
        /// Media or Article
        /// </summary>
        public int TagType { get; set; }

        public Nullable<int> TagArticleId { get; set; }

        public Nullable<int> TagMediaId { get; set; }

        public string TagCreatedBy { get; set; }

        public DateTime TagCreatedDate { get; set; }

        public string TagModifiedBy { get; set; }

        public Nullable<DateTime> TagModifiedDate { get; set; }
    }
}
