namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_infor_ms
    {
        [Key]
        public Guid infor_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(50)]
        public string infor_no { get; set; }

        [StringLength(50)]
        public string infor_title { get; set; }

        [StringLength(50)]
        public string infor_cotent { get; set; }

        public long? infor_cls { get; set; }

        public DateTime? launch_date { get; set; }

        public Guid? launch_person { get; set; }

        public Guid? implement_person { get; set; }

        public long? infor_status { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public int autoincr { get; set; }
    }
}
