using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Venta")]
	public class Venta
	 {
		[Key]
		public int IdVenta { get; set; }
		public int? IdUsuario { get; set; }
		public int? IdCliente { get; set; }
		public int? IdMetodoPago { get; set; }
		[MaxLength(50)]
		public string? TipoDocumento { get; set; }
		[MaxLength(50)]
		public string? NumeroDocumento { get; set; }
		[MaxLength(50)]
		public string? DocumentoCliente { get; set; }
		[MaxLength(100)]
		public string? NombreCliente { get; set; }
		public decimal? SubTotal { get; set; }
		public decimal? ImpuestoTotal { get; set; }
		public decimal? MontoPago { get; set; }
		public decimal? MontoCambio { get; set; }
		public decimal? MontoTotal { get; set; }
		public DateTime? FechaRegistro { get; set; }
		public bool? Activo { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
