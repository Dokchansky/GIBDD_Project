namespace GIBDD.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeFine")]
    public partial class TypeFineEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeFineEntity()
        {
            Fine = new HashSet<FineEntity>();
        }

        [Column("ID")]
        public long ID { get; set; }

        [Column("Purpose")]
        [Required]
        [StringLength(2147483647)]
        public string Purpose { get; set; }
        
        [Column("Value")]
        [Required]
        [StringLength(2147483647)]
        public string Value { get; set; }

        [Column("Date")]
        [Required]
        [StringLength(2147483647)]
        public string Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FineEntity> Fine { get; set; }
    }
}
