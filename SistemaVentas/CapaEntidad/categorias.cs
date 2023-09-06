namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class categorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categorias()
        {
            products = new HashSet<products>();
        }

        [Key]
        public int id_categoria { get; set; }

        [Required]
        [StringLength(30)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<products> products { get; set; }
    }
}
