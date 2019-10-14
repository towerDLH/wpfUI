namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_lot_ms
    {
        [Key]
        public Guid lot_id { get; set; }

        [StringLength(152)]
        public string lot_no { get; set; }

        [StringLength(152)]
        public string iner_lot_no { get; set; }

        public Guid? sourceID { get; set; }

        [StringLength(150)]
        public string sourceTable { get; set; }

        public long? generator { get; set; }

        public long? lot_status { get; set; }

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
    }
}
