namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_UserGroup
    {
        [Key]
        [StringLength(50)]
        public string UGID { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserId { get; set; }
    }
}
