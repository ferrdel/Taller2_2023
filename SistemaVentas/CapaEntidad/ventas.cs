namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ventas()
        {
            venta_detalle = new HashSet<venta_detalle>();
        }

        [Key]
        public int id_venta { get; set; }

        public int id_perfil { get; set; }

        public int id_cliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_venta { get; set; }

        public decimal numero_venta { get; set; }

        public int id_factura { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        public float total_venta { get; set; }

        [StringLength(25)]
        public string tipo_pago { get; set; }

        public virtual clientes clientes { get; set; }

        public virtual tipos_facturas tipos_facturas { get; set; }

        public virtual usuarios usuarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_detalle> venta_detalle { get; set; }
    }
}
