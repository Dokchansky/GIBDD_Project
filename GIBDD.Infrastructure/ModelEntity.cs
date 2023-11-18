namespace GIBDD.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class ModelEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelEntity()
        {
            Transport = new HashSet<TransportEntity>();
        }

        [Column("ID")]
        public long ID { get; set; }

        [Column("Name")]
        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [Column("BrandID")]
        public long BrandID { get; set; }

        [Column("CarCategoryID")]
        public long CarCategoryID { get; set; }

        public virtual BrandEntity Brand { get; set; }

        public virtual CarСategoryEntity CarСategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportEntity> Transport { get; set; }
    }
}
