using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class WizardEntity
    {
        public Nullable<int> WizardId { get; set; }

        public string MasterName { get; set; }

        public string MasterAcronym { get; set; }

        public string MasterDescription { get; set; }

        public string MasterStatus { get; set; }

        public DateTime MasterActiveFrom { get; set; }

        public Nullable<DateTime> MasterActiveTill { get; set; }

        public string MasterCreatedBy { get; set; }

        public DateTime MasterCreatedDate { get; set; }

        public string MasterModifiedBy { get; set; }

        public Nullable<DateTime> MasterModifiedDate { get; set; }
    }
}
