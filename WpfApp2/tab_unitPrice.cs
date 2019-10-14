namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_unitPrice
    {
        [Key]
        public Guid unitPrice_id { get; set; }

        [StringLength(50)]
        public string unitPrice_code { get; set; }

        public Guid? shiftUnit { get; set; }

        public Guid? baseUnit { get; set; }

        public Guid? pm_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunsi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunbo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unitPrice { get; set; }

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

        [StringLength(50)]
        public string Size { get; set; }
    }
}
