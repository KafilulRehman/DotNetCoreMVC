using System;
using System.Collections.Generic;

#nullable disable

namespace MVCApp.Data.Models
{
    public partial class User
    {
        public User()
        {
            ProjectConstantCodeCreatedByNavigations = new HashSet<ProjectConstantCode>();
            ProjectConstantCodeModifiedByNavigations = new HashSet<ProjectConstantCode>();
            ProjectConstantCreatedByNavigations = new HashSet<ProjectConstant>();
            ProjectConstantModifiedByNavigations = new HashSet<ProjectConstant>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserContactNo { get; set; }
        public string UserEmail { get; set; }
        public string UserAddress { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int? RoleId { get; set; }
        public int? SubscriberId { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsFinalized { get; set; }
        public bool? IsStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifedDate { get; set; }

        public virtual ProjectConstant Role { get; set; }
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<ProjectConstantCode> ProjectConstantCodeCreatedByNavigations { get; set; }
        public virtual ICollection<ProjectConstantCode> ProjectConstantCodeModifiedByNavigations { get; set; }
        public virtual ICollection<ProjectConstant> ProjectConstantCreatedByNavigations { get; set; }
        public virtual ICollection<ProjectConstant> ProjectConstantModifiedByNavigations { get; set; }
    }
}
