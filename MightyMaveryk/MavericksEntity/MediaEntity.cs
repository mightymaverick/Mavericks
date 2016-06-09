using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class MediaEntity
    {
        public Nullable<int> MediaId { get; set; }

        public Nullable<int> UserId { get; set; }

        public Nullable<int> EventId { get; set; }

        /// <summary>
        /// Photo or Video
        /// </summary>
        public int MediaType { get; set; }

        /// <summary>
        /// Profile Picture, Album Image, Thumbnail, etc
        /// </summary>
        public int MediaUsageType { get; set; }


    }
}
