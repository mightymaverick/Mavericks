using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aazhi.MightyMaverick.MavericksEntity
{
    /// <summary>
    /// The class contains the sub-master (metadata) of the application.
    /// </summary>
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

        public int MasterDetailCreatedBy { get; set; }

        public DateTime MasterDetailCreatedDate { get; set; }

        public Nullable<int> MasterDetailModifiedBy { get; set; }

        public Nullable<DateTime> MasterDetailModifiedDate { get; set; }
    }
}
