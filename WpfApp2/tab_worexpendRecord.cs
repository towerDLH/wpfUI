namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_worexpendRecord
    {
        [Key]
        public Guid worexpendRecord_id { get; set; }

        public Guid? worsheet_id { get; set; }

        public Guid? stockReceivedPlan_id { get; set; }

        public Guid? stockReceivedRecord_id { get; set; }

        public Guid? stockMoke_id { get; set; }

        public Guid? item_id { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? location_id { get; set; }

        public decimal? outputNum { get; set; }

        public Guid? outputUnit { get; set; }

        public decimal? consumptionNum { get; set; }

        public decimal? thisTimeconsumptionNum { get; set; }

        public Guid? consumptionUnit { get; set; }

        public Guid? torsionPm { get; set; }

        public Guid? torsionProc { get; set; }

        public decimal? torsionNum { get; set; }

        public decimal? thisTimetorsionNum { get; set; }

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

        public int? pmstatus { get; set; }

        public Guid? stockReceivedPmRecord_id { get; set; }

        [StringLength(30)]
        public string stockmonth { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? prc_id { get; set; }
    }
}
