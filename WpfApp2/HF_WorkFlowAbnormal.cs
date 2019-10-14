namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkFlowAbnormal
    {
        [Key]
        [StringLength(50)]
        public string AbnormalId { get; set; }

        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(512)]
        public string AbnormalMsg { get; set; }

        public DateTime? AbnormalTime { get; set; }
    }
}
