using CleanArchitecture.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.entities
{
	public class Product : AuditEntity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; } = String.Empty;
		public string Description { get; set; } = String.Empty;
		public int Stock { get; set; }
		public double Price { get; set; }
	}
}
