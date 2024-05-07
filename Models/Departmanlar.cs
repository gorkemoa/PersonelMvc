using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDbMvc.Models
{
	public class Departmanlar
	{
		[Key]
		public int Id { get; set; }
		public string? DepartmanAd { get; set; }
		public string? Acıklama { get; set; }

        public ICollection<Personel> Personels { get; set; }

	}
}

