namespace THLTWLAB3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Required(ErrorMessage ="id khong duoc trong")]
        public int id { get; set; }


        [Required(ErrorMessage = "Tieu de khong duoc trong")]
        [StringLength(100, ErrorMessage = "Tieu de khong duoc qua 100 ky tu")]
        public string title { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(10)]
        public string img { get; set; }
        [Required]
        [Range(1000, 1000000, ErrorMessage = "Gia phai tu 1000 den 1000000")]
        public int? price { get; set; }
    }
}
