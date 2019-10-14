namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_salesReturn
    {
        [Key]
        public Guid salesReturn_id { get; set; }

        [StringLength(50)]
        public string salesReturn_code { get; set; }

        public Guid? saleSend_id { get; set; }

        public DateTime? OrderTime { get; set; }

        public Guid? ReceivePerson { get; set; }

        public Guid? ReturnWh { get; set; }

        public Guid? customer_id { get; set; }

        public Guid? dl_curr_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? con_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_curr_amt { get; set; }

        [StringLength(50)]
        public string stock_month { get; set; }

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
