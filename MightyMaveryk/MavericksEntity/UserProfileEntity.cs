using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class UserProfileEntity
    {
        public Nullable<int> UserProfileId { get; set; }

        public int UserId { get; set; }

        public string UserFirstname { get; set; }

        public string UserLastName { get; set; }

        public string UserNickName { get; set; }

        public string ProfileName { get; set; }

        public int ProfileStatus { get; set; }

        public Nullable<DateTime> ProfileActiveDate { get; set; }

        public string ProfileCreatedBy { get; set; }

        public DateTime ProfileCreatedDate { get; set; }

        public string ProfileModifiedBy { get; set; }

        public Nullable<DateTime> ProfileModifiedDate { get; set; }
    }
}
