using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Rol")]
	public class Rol
	 {
		[Key]
		public int IdRol { get; set; }
		[MaxLength(50)]
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		[Required]
		public bool Activo { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
