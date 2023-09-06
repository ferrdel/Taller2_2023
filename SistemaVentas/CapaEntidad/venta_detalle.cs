namespace CapaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class venta_detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_venta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_detalle { get; set; }

        public int id_producto { get; set; }

        public int cantidad { get; set; }

        public double subTotal { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        public virtual products products { get; set; }

        public virtual ventas ventas { get; set; }
    }
}
