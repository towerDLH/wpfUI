namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_OperatorInstance
    {
        [Key]
        [StringLength(50)]
        public string OperatorInstanceId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string WorkTaskInstanceId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? OperType { get; set; }

        public int? OperRealtion { get; set; }

        [StringLength(256)]
        public string OperContent { get; set; }

        [StringLength(256)]
        public string OperContentText { get; set; }

        [StringLength(1)]
        public string OperStatus { get; set; }

        public DateTime? OperDateTime { get; set; }

        [StringLength(256)]
        public string ChangeOperator { get; set; }

        [StringLength(50)]
        public string DoResult { get; set; }

        [StringLength(256)]
        public string DoResultMsg { get; set; }

        [StringLength(50)]
        public string DoCommandName { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ReturnOperatorInsId { get; set; }

        public int? OperNum { get; set; }

        [StringLength(50)]
        public string FromOperatorInsId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
