using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Usuario")]
	public class Usuario
	 {
		[Key]
		public int IdUsuario { get; set; }
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
		public string Login { get; set; }
		[Required]
		public byte[] Clave { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
