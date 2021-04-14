using System;
using System.Collections.Generic;

#nullable disable

namespace MVCApp.Data.Models
{
    public partial class ProjectConstantCode
    {
        public ProjectConstantCode()
        {
            ProjectConstants = new HashSet<ProjectConstant>();
        }

        public int ProjectConstantCodeId { get; set; }
        public string ProjectConstantCodeName { get; set; }
        public int? SubscriberId { get; set; }
        public bool? IsStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<ProjectConstant> ProjectConstants { get; set; }
    }
}
