using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.entities
{
	public class Product
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; } = String.Empty;
		public string Description { get; set; } = String.Empty;
		public string Stock { get; set; }
		public double Price { get; set; }
	}
}
