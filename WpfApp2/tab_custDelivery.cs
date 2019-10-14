namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_custDelivery
    {
        [Key]
        public Guid deliver_id { get; set; }

        public Guid? customer_id { get; set; }

        [StringLength(64)]
        public string delivery_person { get; set; }

        [StringLength(16)]
        public string delivery_mobile { get; set; }

        [StringLength(16)]
        public string delivery_tel { get; set; }

        [StringLength(16)]
        public string mail_no { get; set; }

        [StringLength(16)]
        public string fax_no { get; set; }

        public short? huoType { get; set; }

        [StringLength(64)]
        public string city { get; set; }

        [StringLength(256)]
        public string address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? is_default { get; set; }

        [StringLength(256)]
        public string remark { get; set; }

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

        public Guid? company_id { get; set; }
    }
}
