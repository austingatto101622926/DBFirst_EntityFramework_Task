namespace SwinnnyAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        [StringLength(50)]
        public string ISBN { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? Year { get; set; }

        [StringLength(50)]
        public string StudentId { get; set; }

        [Required]
        [StringLength(5)]
        public string AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Student Student { get; set; }
    }
}
