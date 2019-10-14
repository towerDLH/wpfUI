namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Part
    {
        [Key]
        public Guid roleid2 { get; set; }

        public bool Validflg { get; set; }

        public Guid sectionid { get; set; }

        public Guid? parentid { get; set; }

        [Required]
        [StringLength(40)]
        public string rolename { get; set; }

        [StringLength(512)]
        public string roleDes { get; set; }

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

        public int? associationid { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(255)]
        public string OrganizeName { get; set; }
    }
}
