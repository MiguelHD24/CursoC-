using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Compra")]
	public class Compra
	 {
		[Key]
		public int IdCompra { get; set; }
		[Required]
		public int IdUsuario { get; set; }
		[Required]
		public int IdProveedor { get; set; }
		[MaxLength(50)]
		[Required]
		public string TipoDocumento { get; set; }
		[MaxLength(50)]
		[Required]
		public string NumeroDocumento { get; set; }
		[Required]
		public decimal SubTotal { get; set; }
		[Required]
		public decimal ImpuestoTotal { get; set; }
		[Required]
		public decimal Total { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		[Required]
		public bool Activo { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
