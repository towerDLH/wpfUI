namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_SERVERIMAGE
    {
        [Key]
        [Column(Order = 0)]
        public Guid serverinformation { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string clientaddress { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string serveraddress { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string username { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string password { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string State { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string netpointcode { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime regdatetime { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] lastchanged { get; set; }

        public Guid? objectPicturesId { get; set; }

        public bool? validflg { get; set; }

        public int? statusType { get; set; }
    }
}
