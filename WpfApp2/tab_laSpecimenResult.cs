namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_laSpecimenResult
    {
        [Key]
        public Guid laSpecimenResult_id { get; set; }

        public Guid? ins_id { get; set; }

        public Guid? ins_dlt_id { get; set; }

        public Guid? standard_id { get; set; }

        public Guid? require_id { get; set; }

        public long? requireQualified { get; set; }

        public Guid? parameter_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_stvlue { get; set; }

        public long? parameterQualified { get; set; }

        public int? specimenNum { get; set; }

        [StringLength(50)]
        public string specimenVal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_mine { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parameter_max { get; set; }

        public Guid? parameter_unit { get; set; }

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

        public Guid? ins_userid { get; set; }
    }
}
