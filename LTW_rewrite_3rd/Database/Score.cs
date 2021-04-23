namespace LTW_rewrite_3rd.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string C01_studentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string C02_subjectID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string C03_courseID { get; set; }

        public double? C04_score { get; set; }
    }
}
