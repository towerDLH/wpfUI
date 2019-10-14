namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_USER
    {
        [Key]
        public Guid userid { get; set; }

        [StringLength(50)]
        public string usercode { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(20)]
        public string ip { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        public int? userlock { get; set; }

        public Guid? staffid { get; set; }

        public Guid? s_Part { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

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

        [StringLength(50)]
        public string passwordB { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }
    }
}
