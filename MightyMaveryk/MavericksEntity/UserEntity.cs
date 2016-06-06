using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class UserEntity
    {
        public Nullable<int> UserId { get; set; }

        public string UserPassThroughName { get; set; }

        public string UserPassThroughKey { get; set; }

        public string UserEmail { get; set; }

        public int UserStatus { get; set; }

        public int UserType { get; set; }

        public string UserCreatedBy { get; set; }

        public DateTime UserCreatedDate { get; set; }

        public string UserModifiedBy { get; set; }

        public Nullable<DateTime> UserModifiedDate { get; set; }
    }
}
