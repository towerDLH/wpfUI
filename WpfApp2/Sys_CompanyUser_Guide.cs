namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_CompanyUser_Guide
    {
        public Guid Id { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? UpdateUser { get; set; }

        public byte? Validflg { get; set; }

        [StringLength(4000)]
        public string Cache { get; set; }
    }
}
