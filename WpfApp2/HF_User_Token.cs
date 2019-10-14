namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_User_Token
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(128)]
        public string UserToKen { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
