namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_ServiceMessage
    {
        [Key]
        [StringLength(50)]
        public string MessageId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string WorkTaskInstanceId { get; set; }

        [StringLength(1024)]
        public string Content { get; set; }

        public DateTime? SendTime1 { get; set; }

        public DateTime? SendTime2 { get; set; }

        public DateTime? SendTime3 { get; set; }

        public int? DoneFlag1 { get; set; }

        public int? DoneFlag2 { get; set; }

        public int? DoneFlag3 { get; set; }

        [StringLength(50)]
        public string MsgType { get; set; }

        [StringLength(512)]
        public string Users1 { get; set; }

        [StringLength(512)]
        public string Users2 { get; set; }

        [StringLength(512)]
        public string Users3 { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
    }
}
