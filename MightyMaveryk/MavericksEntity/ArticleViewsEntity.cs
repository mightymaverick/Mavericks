using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class ArticleViewsEntity
    {
        public Nullable<int> ViewId { get; set; }

        public int ArticleId { get; set; }

        public string FromIP { get; set; }

        public DateTime ViewedTime { get; set; }

        /// <summary>
        /// Blog or Forum
        /// </summary>
        public int ArticleType { get; set; }

        /// <summary>
        /// The locale of the viewer based on the language setting of the browser
        /// </summary>
        public string ViewedRegion { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
