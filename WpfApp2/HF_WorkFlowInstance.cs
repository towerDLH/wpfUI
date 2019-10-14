namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkFlowInstance
    {
        [Key]
        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        public int? WorkFlowNo { get; set; }

        [StringLength(128)]
        public string FlowInstanceCaption { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Priority { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public DateTime? StartTime { get; set; }

        [StringLength(50)]
        public string StartUserId { get; set; }

        [StringLength(50)]
        public string StartUserName { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? SuspendTime { get; set; }

        [StringLength(1)]
        public string SuspendStaus { get; set; }

        public int? SuspendTotalSeconds { get; set; }

        public bool? IsSubWorkFlow { get; set; }

        [StringLength(50)]
        public string MainWorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string MainWorkTaskInstanceId { get; set; }

        [StringLength(50)]
        public string MainWorkTaskId { get; set; }

        [StringLength(50)]
        public string MainWorkFlowId { get; set; }

        [StringLength(50)]
        public string NowTaskId { get; set; }

        public bool? IsDebug { get; set; }

        [StringLength(128)]
        public string UserBusinessNO { get; set; }

        [StringLength(128)]
        public string UserBusinessId { get; set; }

        [StringLength(512)]
        public string StatusRemark { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public DateTime? ModifyTime { get; set; }
    }
}
