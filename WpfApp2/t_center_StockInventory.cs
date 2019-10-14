namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_center_StockInventory
    {
        public Guid Id { get; set; }

        public Guid? locationId { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public int? status { get; set; }

        public byte? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        public Guid? PlanUser { get; set; }

        [StringLength(50)]
        public string InventoryName { get; set; }
    }
}
