using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
	public class Department
	{
		[Key]
		public int Id { get; set; }
		public string DepartmentName { get; set; } = string.Empty;
    }
}
