namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_sales_tr
    {
        [Key]
        public Guid order_id { get; set; }

        public long? order_type { get; set; }

        [StringLength(128)]
        public string sale_order_code { get; set; }

        public Guid? customer_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? taxrate { get; set; }

        public long? inner_out_cls { get; set; }

        public Guid? del_person { get; set; }

        public Guid? del_location { get; set; }

        public long? con_amt_op_type { get; set; }

        public Guid? dl_curr_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? con_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_curr_amt { get; set; }

        public long? tran_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? transfer_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? safe_amt { get; set; }

        public Guid? company_id { get; set; }

        public long? ordre_status { get; set; }

        public long? ship_status { get; set; }

        public int? bom_status { get; set; }

        public DateTime? last_ship_date { get; set; }

        public DateTime? del_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ship_number { get; set; }

        public long? is_charge { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? free_charge { get; set; }

        [StringLength(258)]
        public string free_reason { get; set; }

        public DateTime? order_create_time { get; set; }

        public Guid? order_create_person_id { get; set; }

        [StringLength(1024)]
        public string remark1 { get; set; }

        [StringLength(1024)]
        public string remark2 { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? ensuer_amount { get; set; }
    }
}
