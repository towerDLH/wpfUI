namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_prod_desc_ms
    {
        [Key]
        public Guid prod_id { get; set; }

        public Guid? fac_cd { get; set; }

        public Guid? depart_cd { get; set; }

        [StringLength(12)]
        public string prod_code { get; set; }

        [StringLength(100)]
        public string prod_desc { get; set; }

        public Guid? person_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(255)]
        public string OrganizeName { get; set; }

        public int? LeaderId { get; set; }

        [StringLength(50)]
        public string FatherId { get; set; }

        public Guid? prodLevel_id { get; set; }
    }
}
