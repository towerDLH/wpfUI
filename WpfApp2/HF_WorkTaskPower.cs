namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTaskPower
    {
        [Key]
        [StringLength(50)]
        public string Powerid { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(256)]
        public string PowerName { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }
    }
}
