namespace LTW_rewrite_3rd.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        [Key]
        [StringLength(50)]
        public string C01_id { get; set; }

        [Required]
        [StringLength(50)]
        public string C02_firstname { get; set; }

        public string C03_lastname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C04_birthday { get; set; }

        public bool? C05_gender { get; set; }

        public string C06_phonenumber { get; set; }

        public string C07_address { get; set; }

        [Column(TypeName = "image")]
        public byte[] C08_avatar { get; set; }
    }
}
