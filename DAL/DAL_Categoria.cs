using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Categoria
	{
		 public static Categoria Insert (Categoria Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Categoria.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Categoria Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Categoria.Find(Entidad.IdCategoria);
				 Registro.Descripcion = Entidad.Descripcion;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Categoria Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Categoria.Find(Entidad.IdCategoria);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Categoria Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Categoria.Where(a=>a.IdCategoria == Entidad.IdCategoria).Count() > 0;
			}
		}
		 public static Categoria Registro (Categoria Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Categoria.Where(a=>a.IdCategoria == Entidad.IdCategoria).SingleOrDefault();
			}
		}
		 public static List<Categoria> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Categoria.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
