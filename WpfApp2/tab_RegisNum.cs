namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_RegisNum
    {
        [Key]
        public Guid RegisNum_id { get; set; }

        [StringLength(50)]
        public string RegisNum_code { get; set; }

        [StringLength(50)]
        public string RegisNum_Name { get; set; }

        public Guid? facOutside_id { get; set; }

        public DateTime? expireTime { get; set; }

        public int? seq { get; set; }

        public long? isdefault { get; set; }

        public bool? isOurFactory { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        public DateTime? regdatetime { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
