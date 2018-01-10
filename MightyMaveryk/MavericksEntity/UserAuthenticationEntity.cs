using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class UserAuthenticationEntity
    {
        public Nullable<int> UserAuthenticationId { get; set; }

        public int UserId { get; set; }

        public bool IsSuperUser { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsBlogModerator { get; set; }

        public bool IsForumModerator { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedTime { get; set; }

        public Nullable<int> ModifiedBy { get; set; }

        public Nullable<int> ModifiedDate { get; set; }
    }
}