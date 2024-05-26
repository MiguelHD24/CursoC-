using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Cliente")]
	public class Cliente
	 {
		[Key]
		public int IdCliente { get; set; }
		[MaxLength(50)]
		[Required]
		public string Documento { get; set; }
		[MaxLength(50)]
		[Required]
		public string NombreCompleto { get; set; }
		[MaxLength(50)]
		[Required]
		public string Correo { get; set; }
		[MaxLength(50)]
		[Required]
		public string Telefono { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
