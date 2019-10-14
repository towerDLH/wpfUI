namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_worequipmentRecord
    {
        [Key]
        public Guid worequipmentRecord_id { get; set; }

        public Guid? worsheet_id { get; set; }

        public Guid? equipment_id { get; set; }

        public Guid? equipRecord_id { get; set; }

        public DateTime? startDatetime { get; set; }

        public DateTime? endDatetime { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        public DateTime? regdatetime { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

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
