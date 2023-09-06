using CapaEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaData
{
    public partial class DassContext : DbContext
    {
        public DassContext()
            : base("name=DassConnection")
        {
        }

        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<tipos_facturas> tipos_facturas { get; set; }
        public virtual DbSet<tipos_perfiles> tipos_perfiles { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<venta_detalle> venta_detalle { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categorias>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<categorias>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<categorias>()
                .HasMany(e => e.products)
                .WithRequired(e => e.categorias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.nombre_c)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.apellido_c)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.clientes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.venta_detalle)
                .WithRequired(e => e.products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipos_facturas>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipos_facturas>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<tipos_facturas>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.tipos_facturas)
                .HasForeignKey(e => e.id_factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipos_perfiles>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipos_perfiles>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<tipos_perfiles>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.tipos_perfiles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.usuarios)
                .HasForeignKey(e => e.id_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venta_detalle>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<ventas>()
                .Property(e => e.numero_venta)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ventas>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<ventas>()
                .Property(e => e.tipo_pago)
                .IsUnicode(false);

            modelBuilder.Entity<ventas>()
                .HasMany(e => e.venta_detalle)
                .WithRequired(e => e.ventas)
                .WillCascadeOnDelete(false);
        }
    }
}
