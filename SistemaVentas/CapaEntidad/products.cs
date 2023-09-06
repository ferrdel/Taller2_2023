namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public products()
        {
            venta_detalle = new HashSet<venta_detalle>();
        }

        [Key]
        public int id_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public double precio_venta { get; set; }

        public int stock_min { get; set; }

        public int stock { get; set; }

        public string imagen { get; set; }

        public int id_categoria { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        public virtual categorias categorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_detalle> venta_detalle { get; set; }
    }
}
