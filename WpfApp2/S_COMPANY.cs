namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_COMPANY
    {
        [Key]
        [StringLength(20)]
        public string companycode { get; set; }

        [Required]
        [StringLength(40)]
        public string companyname { get; set; }

        [StringLength(20)]
        public string legal { get; set; }

        [StringLength(80)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(20)]
        public string fax { get; set; }

        [StringLength(30)]
        public string linceseno { get; set; }

        [StringLength(30)]
        public string productionlicenses { get; set; }

        [StringLength(30)]
        public string regnumber { get; set; }

        [StringLength(30)]
        public string taxnumber { get; set; }

        public bool? systemflg { get; set; }

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

        [Column(TypeName = "image")]
        public byte[] businesscopy { get; set; }

        [Column(TypeName = "image")]
        public byte[] companylogo { get; set; }

        [StringLength(20)]
        public string cid { get; set; }

        public Guid? companyid { get; set; }

        public string introduce { get; set; }

        [StringLength(100)]
        public string EBusinessID { get; set; }

        [StringLength(100)]
        public string AppKey { get; set; }
    }
}
