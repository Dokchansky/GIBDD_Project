namespace GIBDD.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class BrandEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrandEntity()
        {
            Model = new HashSet<ModelEntity>();
        }

        [Column("ID")]
        public long ID { get; set; }

        [Required]
        [StringLength(2147483647)]

        [Column("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelEntity> Model { get; set; }
    }
}
