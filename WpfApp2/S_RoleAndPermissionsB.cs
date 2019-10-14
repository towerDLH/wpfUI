namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_RoleAndPermissionsB
    {
        [Key]
        public Guid privilegeid { get; set; }

        public Guid roleid2 { get; set; }

        public Guid formid { get; set; }

        public Guid operationid2 { get; set; }

        public bool Validflg { get; set; }

        public int type { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime regdatetime { get; set; }

        [Required]
        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] lastchanged { get; set; }

        public bool isActivation { get; set; }
    }
}
