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

        /// <summary>
        /// Jpeg, PNG, MP4, MP3
        /// </summary>
        public int MediaExtensionType { get; set; }

        public Nullable<int> MediaSequence { get; set; }

        public string MediaTitle { get; set; }

        public string MediaFileName { get; set; }

        public string MediaMetaType { get; set; }

        public string MediaFileContent { get; set; }

        public string MediaDescription { get; set; }

        public string MediaTag { get; set; }

        public string Location { get; set; }

        public string MediaPath { get; set; }

        public int MediaStatus { get; set; }

        public string MediaCreatedBy { get; set; }

        public DateTime MediaCreatedDate { get; set; }

        public string MediaMidifiedBy { get; set; }

        public Nullable<DateTime> MediaModifiedDate { get; set; }
    }
}
