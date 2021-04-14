using System;
using System.Collections.Generic;

#nullable disable

namespace MVCApp.Data.Models
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            ProjectConstantCodes = new HashSet<ProjectConstantCode>();
            ProjectConstants = new HashSet<ProjectConstant>();
            Users = new HashSet<User>();
        }

        public int SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberDisplayName { get; set; }
        public string SubscriberLocation { get; set; }
        public string SubscriberAddress { get; set; }
        public string SubscriberContactNo { get; set; }
        public string SubscriberEmail { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsFinalized { get; set; }
        public bool? IsStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProjectConstantCode> ProjectConstantCodes { get; set; }
        public virtual ICollection<ProjectConstant> ProjectConstants { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
