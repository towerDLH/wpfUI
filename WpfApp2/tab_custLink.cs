namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_custLink
    {
        [Key]
        public Guid link_id { get; set; }

        public Guid? customer_id { get; set; }

        [StringLength(32)]
        public string link_name { get; set; }

        [StringLength(16)]
        public string link_mobile { get; set; }

        [StringLength(16)]
        public string link_tel { get; set; }

        [StringLength(16)]
        public string link_fax { get; set; }

        [StringLength(32)]
        public string link_position { get; set; }

        [StringLength(32)]
        public string link_dep { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
