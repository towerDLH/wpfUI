namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_proceedsDtl
    {
        [Key]
        public Guid proceedsDtl_id { get; set; }

        public Guid? proceedsPlan_id { get; set; }

        public Guid? order_id { get; set; }

        public DateTime? paymentDate { get; set; }

        public long? paymentStatu { get; set; }

        public int? dueNum { get; set; }

        public decimal? amount { get; set; }

        public Guid? curr { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [StringLength(32)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? deleteuser { get; set; }

        public DateTime? deletetime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
