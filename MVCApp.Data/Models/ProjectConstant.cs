using System;
using System.Collections.Generic;

#nullable disable

namespace MVCApp.Data.Models
{
    public partial class ProjectConstant
    {
        public ProjectConstant()
        {
            Users = new HashSet<User>();
        }

        public int ProjectConstantId { get; set; }
        public string ProjectConstantName { get; set; }
        public int? ProjectConstantCodeId { get; set; }
        public int? SubscriberId { get; set; }
        public bool? IsStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual ProjectConstantCode ProjectConstantCode { get; set; }
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
