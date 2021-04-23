namespace LTW_rewrite_3rd.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string C01_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string C02_name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime C03_datestart { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime C04_dateend { get; set; }
    }
}
