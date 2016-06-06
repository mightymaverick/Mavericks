using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    public class ApprenticeEntity
    {
        public Nullable<int> ApprenticeId { get; set; }

        public int WizardId { get; set; }

        public string MasterDetailName { get; set; }

        public string MasterDetailAcronym { get; set; }

        public string MasterDetailDescription { get; set; }

        public DateTime MasterDetailActiveFrom { get; set; }

        public DateTime MasterDetailActiveTill { get; set; }

        public int MasterDetailStatus { get; set; }

        public string MasterDetailCreatedBy { get; set; }

        public DateTime MasterDetailCreatedDate { get; set; }

        public string MasterDetailModifiedBy { get; set; }

        public Nullable<DateTime> MasterDetailModifiedDate { get; set; }
    }
}
