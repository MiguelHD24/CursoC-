using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
	 public class BDDBVENTASDEMO:DbContext
	{
		public BDDBVENTASDEMO():base(Conexion.ConexionString(true)){}
		 public virtual DbSet<Arqueo_Caja> Arqueo_Caja{get;set;}
		 public virtual DbSet<Categoria> Categoria{get;set;}
		 public virtual DbSet<Cliente> Cliente{get;set;}
		 public virtual DbSet<Compra> Compra{get;set;}
		 public virtual DbSet<Detalle_Compra> Detalle_Compra{get;set;}
		 public virtual DbSet<Detalle_Venta> Detalle_Venta{get;set;}
		 public virtual DbSet<Metodo_Pago> Metodo_Pago{get;set;}
		 public virtual DbSet<Negocio> Negocio{get;set;}
		 public virtual DbSet<Permiso> Permiso{get;set;}
		 public virtual DbSet<Producto> Producto{get;set;}
		 public virtual DbSet<Proveedor> Proveedor{get;set;}
		 public virtual DbSet<Rol> Rol{get;set;}
		 public virtual DbSet<sysdiagrams> sysdiagrams{get;set;}
		 public virtual DbSet<Usuario> Usuario{get;set;}
		 public virtual DbSet<Venta> Venta{get;set;}
		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categoria>().Property(e => e.Descripcion).IsUnicode(false);
			modelBuilder.Entity<Cliente>().Property(e => e.Documento).IsUnicode(false);
			modelBuilder.Entity<Cliente>().Property(e => e.NombreCompleto).IsUnicode(false);
			modelBuilder.Entity<Cliente>().Property(e => e.Correo).IsUnicode(false);
			modelBuilder.Entity<Cliente>().Property(e => e.Telefono).IsUnicode(false);
			modelBuilder.Entity<Compra>().Property(e => e.TipoDocumento).IsUnicode(false);
			modelBuilder.Entity<Compra>().Property(e => e.NumeroDocumento).IsUnicode(false);
			modelBuilder.Entity<Metodo_Pago>().Property(e => e.Nombre).IsUnicode(false);
			modelBuilder.Entity<Metodo_Pago>().Property(e => e.Descripcion).IsUnicode(false);
			modelBuilder.Entity<Negocio>().Property(e => e.Nombre).IsUnicode(false);
			modelBuilder.Entity<Negocio>().Property(e => e.RUC).IsUnicode(false);
			modelBuilder.Entity<Negocio>().Property(e => e.Direccion).IsUnicode(false);
			modelBuilder.Entity<Permiso>().Property(e => e.NombreMenu).IsUnicode(false);
			modelBuilder.Entity<Producto>().Property(e => e.Codigo).IsUnicode(false);
			modelBuilder.Entity<Producto>().Property(e => e.Nombre).IsUnicode(false);
			modelBuilder.Entity<Producto>().Property(e => e.Descripcion).IsUnicode(false);
			modelBuilder.Entity<Proveedor>().Property(e => e.Documento).IsUnicode(false);
			modelBuilder.Entity<Proveedor>().Property(e => e.RazonSocial).IsUnicode(false);
			modelBuilder.Entity<Proveedor>().Property(e => e.Correo).IsUnicode(false);
			modelBuilder.Entity<Proveedor>().Property(e => e.Telefono).IsUnicode(false);
			modelBuilder.Entity<Rol>().Property(e => e.Descripcion).IsUnicode(false);
			modelBuilder.Entity<sysdiagrams>().Property(e => e.name).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Documento).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.NombreCompleto).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Correo).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Login).IsUnicode(false);
			modelBuilder.Entity<Venta>().Property(e => e.TipoDocumento).IsUnicode(false);
			modelBuilder.Entity<Venta>().Property(e => e.NumeroDocumento).IsUnicode(false);
			modelBuilder.Entity<Venta>().Property(e => e.DocumentoCliente).IsUnicode(false);
			modelBuilder.Entity<Venta>().Property(e => e.NombreCliente).IsUnicode(false);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			 base.OnModelCreating(modelBuilder);
		}
		}
	}
