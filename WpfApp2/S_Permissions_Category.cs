namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Permissions_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Permissions_Category()
        {
            S_Permissions = new HashSet<S_Permissions>();
        }

        [Key]
        public Guid CategoryID { get; set; }

        public int? c_nameid { get; set; }

        [StringLength(250)]
        public string CategoryName { get; set; }

        [StringLength(10)]
        public string sort { get; set; }

        public int? validflg { get; set; }

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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        [StringLength(10)]
        public string keyfalg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_Permissions> S_Permissions { get; set; }
    }
}
