namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_unit_ms
    {
        [Key]
        public Guid unit_id { get; set; }

        [StringLength(50)]
        public string unit_code { get; set; }

        [StringLength(50)]
        public string unit_desc { get; set; }

        public long? unitType { get; set; }

        [StringLength(50)]
        public string language_cls { get; set; }

        [StringLength(50)]
        public string frc_cls { get; set; }

        public Guid? company_id { get; set; }

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
