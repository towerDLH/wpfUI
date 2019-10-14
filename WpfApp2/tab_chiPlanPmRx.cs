namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_chiPlanPmRx
    {
        [Key]
        public Guid chiPlanPmRx_id { get; set; }

        public Guid productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? salePm_id { get; set; }

        public Guid? pm_id { get; set; }

        public Guid? order_id { get; set; }

        public decimal? saleNum { get; set; }

        public decimal? quantity { get; set; }

        public decimal? thisTimequantity { get; set; }

        public bool? hasSale { get; set; }

        [StringLength(1024)]
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
