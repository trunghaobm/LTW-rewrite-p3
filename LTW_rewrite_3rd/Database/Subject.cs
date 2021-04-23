namespace LTW_rewrite_3rd.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject")]
    public partial class Subject
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string C01_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string C02_name { get; set; }
    }
}
