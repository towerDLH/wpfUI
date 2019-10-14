namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_PHONE
    {
        [Key]
        public Guid phoneid { get; set; }

        [Required]
        [StringLength(40)]
        public string phonecode { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneexplanation { get; set; }

        [Required]
        [StringLength(20)]
        public string number { get; set; }

        [Required]
        [StringLength(1)]
        public string validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime regdatetime { get; set; }

        [Required]
        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] lastchanged { get; set; }
    }
}
