namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tipos_perfiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipos_perfiles()
        {
            usuarios = new HashSet<usuarios>();
        }

        [Key]
        public int id_tipoPerfil { get; set; }

        [Required]
        [StringLength(30)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}
