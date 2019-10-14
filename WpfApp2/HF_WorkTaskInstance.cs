namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTaskInstance
    {
        [Key]
        [StringLength(50)]
        public string WorkTaskInstanceId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string PreviousTaskInstanceId { get; set; }

        [StringLength(128)]
        public string TaskInstanceCaption { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(256)]
        public string OperatedDes { get; set; }

        [StringLength(50)]
        public string OperatorInstanceId { get; set; }

        [StringLength(512)]
        public string SuccessMsg { get; set; }

        public bool? OutTimeed { get; set; }

        public bool? Reminded { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public DateTime? ClaimTime { get; set; }

        [StringLength(50)]
        public string SourceWorkTaskInstanceId { get; set; }

        [StringLength(256)]
        public string pOperatedDes { get; set; }
    }
}
