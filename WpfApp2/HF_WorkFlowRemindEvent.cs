namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkFlowRemindEvent
    {
        [Key]
        [StringLength(50)]
        public string RemindEventId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public bool? OutTimeSms { get; set; }

        public bool? OutTimeMsg { get; set; }

        public bool? OutTimeEmail { get; set; }

        public bool? ReceiveSms { get; set; }

        public bool? ReceiveMsg { get; set; }

        public bool? ReceiveEmail { get; set; }

        [StringLength(1024)]
        public string OutTimeToUsers { get; set; }

        [StringLength(1024)]
        public string ReceiveToUsers { get; set; }
    }
}
