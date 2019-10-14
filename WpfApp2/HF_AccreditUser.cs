namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_AccreditUser
    {
        [Key]
        [StringLength(50)]
        public string AccreditId { get; set; }

        [Required]
        [StringLength(50)]
        public string AccreditFromUserId { get; set; }

        [StringLength(50)]
        public string FromUserName { get; set; }

        [StringLength(50)]
        public string AccreditToUserId { get; set; }

        [StringLength(50)]
        public string ToUserName { get; set; }

        public DateTime? AccreditDateTime { get; set; }

        [StringLength(1)]
        public string AccreditStatus { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(512)]
        public string Description { get; set; }
    }
}
