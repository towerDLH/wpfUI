namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Organize
    {
        [Key]
        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(128)]
        public string OrganizeName { get; set; }

        [StringLength(50)]
        public string LoginAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string OrgAccount { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(50)]
        public string LinkTel { get; set; }

        [StringLength(512)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string AuditUserId { get; set; }

        [StringLength(50)]
        public string AuditUserName { get; set; }

        public DateTime? AuditTime { get; set; }

        [StringLength(512)]
        public string AuditMsg { get; set; }

        public int? AuditFlag { get; set; }

        public int? Layer { get; set; }

        [StringLength(256)]
        public string EnCode { get; set; }

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

        [StringLength(512)]
        public string WxHostUrl { get; set; }

        [StringLength(50)]
        public string WxCorpId { get; set; }

        public int IsTaskClaim { get; set; }

        [StringLength(128)]
        public string OrganizeShortName { get; set; }

        public int InitFlag { get; set; }
    }
}
