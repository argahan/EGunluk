namespace Egunluk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commentz")]
    public partial class Commentz
    {
        [Key]
        public int commentID { get; set; }

        public int Uid { get; set; }

        public int Nid { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime CDate { get; set; }

        public virtual Note Note { get; set; }

        public virtual User User { get; set; }
    }
}
