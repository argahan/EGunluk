namespace Egunluk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Note()
        {
            Commentzs = new HashSet<Commentz>();
            Tags = new HashSet<Tag>();
            Users = new HashSet<User>();
            Users1 = new HashSet<User>();
        }

        [Key]
        public int Nid { get; set; }

        public int Uid { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column("Note")]
        [Required]
        [StringLength(5000)]
        public string Note1 { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] TitleImage { get; set; }

        public DateTime NDate { get; set; }

        public bool PorP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commentz> Commentzs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users1 { get; set; }
    }
}
