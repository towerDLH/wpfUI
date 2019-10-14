namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Logs
    {
        [Key]
        [StringLength(50)]
        public string LogId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [Column(TypeName = "text")]
        public string LogContent { get; set; }

        public int? LogType { get; set; }

        public DateTime? LogDatetime { get; set; }

        public int? OperateTypeId { get; set; }

        [StringLength(50)]
        public string OperateType { get; set; }

        [StringLength(50)]
        public string LogUserID { get; set; }

        [StringLength(50)]
        public string LogUserName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string IPAddressName { get; set; }

        [StringLength(50)]
        public string Host { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ModuleName { get; set; }

        public int? ExeResult { get; set; }

        public int? LoginType { get; set; }

        [StringLength(50)]
        public string Brower { get; set; }

        public int? DeleteFlag { get; set; }

        public int? EnableFlag { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
