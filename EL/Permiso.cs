using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Permiso")]
	public class Permiso
	 {
		[Key]
		public int IdPermiso { get; set; }
		[Required]
		public int IdRol { get; set; }
		[MaxLength(100)]
		[Required]
		public string NombreMenu { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		[Required]
		public bool Activo { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
