namespace LTW_rewrite_3rd.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [StringLength(100)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }
    }
}
