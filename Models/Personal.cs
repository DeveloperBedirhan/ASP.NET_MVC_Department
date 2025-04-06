using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
	public class Personal
	{
		[Key]
		public int PerId { get; set; }
        public string Name { get; set; } = string.Empty;
		public string Surname { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
    }
}
