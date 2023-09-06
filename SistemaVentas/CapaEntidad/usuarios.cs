namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            ventas = new HashSet<ventas>();
        }

        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string usuario { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }

        public int id_tipoPerfil { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        public virtual tipos_perfiles tipos_perfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }
    }
}
