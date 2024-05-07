using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDbMvc.Models
{
	public class Personel
	{
		[Key]
		public int Id { get; set; }
		public string? Ad { get; set; }
		public string? Soyad { get; set; }
		public string? Sehir { get; set; }
		public int DepartId { get; set; }
		public Departmanlar Depart { get; set; }
	}
}

