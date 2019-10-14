namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Group
    {
        [Key]
        [StringLength(50)]
        public string GroupId { get; set; }

        [StringLength(256)]
        public string GroupName { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string OrganizeName { get; set; }

        [StringLength(256)]
        public string EnCode { get; set; }

        public int IsPublic { get; set; }

        public int? Layer { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public DateTime? ModifyTime { get; set; }

        public int? DeleteFlag { get; set; }

        public int? EnableFlag { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
