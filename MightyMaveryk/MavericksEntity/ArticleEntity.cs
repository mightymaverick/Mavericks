using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class ArticleEntity
    {
        public Nullable<int> ArticleId { get; set; }

        public Nullable<int> UserId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleContent { get; set; }

        public string ArticleType { get; set; }

        public string ArticleTag { get; set; }

        public string ArticleLocation { get; set; }

        public string ArticleSequence { get; set; }

        public int ArticleStatus { get; set; }

        public Nullable<DateTime> ArticlePublishedDate { get; set; }

        public string ArticleCreatedDate { get; set; }

        public string ArticleModifiedBy { get; set; }

        public Nullable<int> ArticleModifiedDate { get; set; }
    }
}
