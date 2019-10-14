namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_pmOutside
    {
        [Key]
        public Guid pmOutside_id { get; set; }

        [StringLength(50)]
        public string pmOutside_code { get; set; }

        public Guid? facOutside_id { get; set; }

        public Guid? pm_id { get; set; }

        [StringLength(50)]
        public string pmOutside_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        public Guid? unit { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [StringLength(50)]
        public string drw_no { get; set; }

        [StringLength(25)]
        public string seiban { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? min_lot_qty { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

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
