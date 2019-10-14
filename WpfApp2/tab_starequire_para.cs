namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_starequire_para
    {
        [Key]
        public Guid parameter_id { get; set; }

        public int? parameter_req { get; set; }

        public Guid? require_id { get; set; }

        [StringLength(35)]
        public string require_no { get; set; }

        [StringLength(64)]
        public string parameter_express { get; set; }

        public long? parameter_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_mine { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_max { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_stvlue { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_accuracy { get; set; }

        public Guid? parameter_unit { get; set; }

        [StringLength(1024)]
        public string parameter_remark { get; set; }

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

        public Guid? sourceparaid { get; set; }
    }
}
