using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class BlogPostEntity
    {
        public Nullable<int> BlogPostId { get; set; }

        public string BlogTitle { get; set; }

        public string BlogArticle { get; set; }

        public string BlogAuthorId { get; set; }

        public Nullable<DateTime> DatePublished { get; set; }

        public string BlogFile { get; set; }

        public string BlogBannerImage { get; set; }

        public bool IsFeatured { get; set; }

        public int BlogCategory { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsCommentsEnabled { get; set; }

        //public Nullable<int> BlogViews { get; set; }

        public int BlogCreatedBy { get; set; }

        public DateTime BlogCreatedDate { get; set; }

        public Nullable<int> BlogModifiedBy { get; set; }

        public Nullable<DateTime> BlogModifiedDate { get; set; }
    }
}
