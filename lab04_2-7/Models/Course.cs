namespace lab04_2_7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [StringLength(128)]
        public string LecturerID { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [StringLength(50)]

        public string Place { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public List<Category> ListCategory = new List<Category>();

        public String Name;
    }
}
