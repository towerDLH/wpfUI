namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QS_ModelPrcExam_RX
    {
        [Key]
        public Guid oPrcExamine_id { get; set; }

        public Guid? bomMultiMode_id { get; set; }

        public Guid? pm_id { get; set; }

        public Guid? proc_id { get; set; }

        public int? seq { get; set; }

        public long? ins_cls { get; set; }

        public Guid? ins_ptn { get; set; }

        public Guid? ins_section_id { get; set; }

        public Guid? checkout_location { get; set; }

        public Guid? checkout_disqualification { get; set; }

        public long? checkType { get; set; }

        [StringLength(516)]
        public string remark { get; set; }

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
