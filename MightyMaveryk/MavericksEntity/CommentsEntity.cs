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

        public int ParentId { get; set; }

        public string PostedBy { get; set; }

        public DateTime PostedTime { get; set; }

        public int CommentStatus { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public Nullable<DateTime> LastModifiedDate { get; set; }
    }
}
