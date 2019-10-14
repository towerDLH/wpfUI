namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_order_prcs_ms
    {
        [Key]
        public Guid proc_id { get; set; }

        public Guid? company_id { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? pm_id { get; set; }

        public Guid? bomMultiMode_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? seq { get; set; }

        public long? proc_ptn { get; set; }

        public long? po_cls { get; set; }

        public long? ind_address_cd { get; set; }

        public long? ind_content { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? prod_lt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? safe_lt { get; set; }

        public long? sply_issue_cls { get; set; }

        public Guid? checkout_location { get; set; }

        public Guid? waitCheck_location { get; set; }

        public Guid? disqualifica_location { get; set; }

        public Guid? scrap_location { get; set; }

        public Guid? comp_location { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? yield_rate { get; set; }

        public Guid? po_persion_id { get; set; }

        public long? po_app_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? per_seq { get; set; }

        public long? act_sbjt { get; set; }

        public long? asset_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? wk_time { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unit_prod_qty { get; set; }

        public long? ins_cls { get; set; }

        public Guid? ins_ptn { get; set; }

        public Guid? ins_section_id { get; set; }

        public long? vou_cls { get; set; }

        public Guid? issue_person_id { get; set; }

        [StringLength(50)]
        public string location_no { get; set; }

        public Guid? acp_person_id { get; set; }

        public long? machine_no { get; set; }

        public long? mold_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? eff_period { get; set; }

        public Guid? vou_section_id { get; set; }

        public long? st_charged_cls { get; set; }

        [StringLength(516)]
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
    }
}
