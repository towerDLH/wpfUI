namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkFlow
    {
        [Key]
        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(128)]
        public string FlowCaption { get; set; }

        [StringLength(50)]
        public string WFClassId { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        public int? IsSignOut { get; set; }

        [StringLength(50)]
        public string SignOutUserId { get; set; }

        [StringLength(512)]
        public string MgrUrl { get; set; }

        public int? IsDebug { get; set; }

        public int OrderNum { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public DateTime? ModifyTime { get; set; }

        public int DeleteFlag { get; set; }

        public int EnableFlag { get; set; }

        [StringLength(512)]
        public string Description { get; set; }
    }
}
