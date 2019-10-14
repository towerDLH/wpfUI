namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Permissions
    {
        [Key]
        public Guid PmsID { get; set; }

        public Guid CategoryID { get; set; }

        public int? p_nameid { get; set; }

        [StringLength(50)]
        public string PmsCode { get; set; }

        [StringLength(250)]
        public string PmsName { get; set; }

        [StringLength(512)]
        public string PmsDes { get; set; }

        public int? sort { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        [StringLength(10)]
        public string keyflag { get; set; }

        public virtual S_Permissions_Category S_Permissions_Category { get; set; }
    }
}
