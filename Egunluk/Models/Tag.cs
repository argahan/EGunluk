namespace Egunluk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tid { get; set; }

        public int Nid { get; set; }

        [Column("Tag")]
        [Required]
        [StringLength(20)]
        public string Tag1 { get; set; }

        public virtual Note Note { get; set; }
    }
}
