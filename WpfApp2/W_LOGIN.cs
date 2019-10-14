namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class W_LOGIN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string usercode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string netpointcode { get; set; }

        [Required]
        [StringLength(20)]
        public string passwords { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string openid { get; set; }

        [Required]
        [StringLength(1)]
        public string factoryflg { get; set; }
    }
}
