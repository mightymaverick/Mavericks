using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class CommentsEntity
    {
        public Nullable<int> CommentId { get; set; }

        public string CommentText { get; set; }

        public bool IsReply { get; set; }

        public Nullable<int> ParentCommentId { get; set; }

        public int PostId { get; set; }

        public Nullable<int> PostedBy { get; set; }

        public bool MarkCommentRead { get; set; }

        public DateTime PostedTime { get; set; }

        public int CommentStatus { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Nullable<int> LastModifiedBy { get; set; }

        public Nullable<DateTime> LastModifiedDate { get; set; }
    }
}
