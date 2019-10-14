namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_purapplication_tr
    {
        [Key]
        public Guid purapplica_id { get; set; }

        public Guid? fac_id { get; set; }

        public DateTime? purapplica_date { get; set; }

        public DateTime? deadline_date { get; set; }

        [StringLength(50)]
        public string purapplica_no { get; set; }

        public Guid? purapplica_person { get; set; }

        public Guid? purchase_person { get; set; }

        public Guid? ctrl_section { get; set; }

        public Guid? entry_person { get; set; }

        public DateTime? entry_date { get; set; }

        public Guid? chk_person { get; set; }

        public DateTime? chk_date { get; set; }

        public int? chkflag { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [StringLength(32)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? deleteuser { get; set; }

        public DateTime? deletetime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
