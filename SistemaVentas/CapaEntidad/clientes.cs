namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            ventas = new HashSet<ventas>();
        }

        [Key]
        public int id_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_c { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_c { get; set; }

        public int dni_c { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_nacimiento { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string direccion { get; set; }

        [Required]
        [StringLength(12)]
        public string telefono { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }
    }
}
