namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_order_StockInventory
    {
        public Guid Id { get; set; }

        public Guid? locationId { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? pmId { get; set; }

        public Guid? prcId { get; set; }

        public Guid? lotId { get; set; }

        public byte? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public int? status { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public int? sysNum { get; set; }

        public int? realNum { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public Guid? CenterInventoryId { get; set; }

        public int? pmstatus { get; set; }

        [StringLength(50)]
        public string stockMonth { get; set; }

        public Guid? fac_Id { get; set; }
    }
}
