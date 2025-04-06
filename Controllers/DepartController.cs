using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartment.Controllers
{
	public class DepartController : Controller
	{
		Context Con = new Context();
		public IActionResult Index()
		{
			var values = Con.Departments.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult YeniDepartman()
		{
			return View();
		}

		[HttpPost]
        public IActionResult YeniDepartman(Department dep)
        {
            Con.Departments.Add(dep);
			Con.SaveChanges();
			return RedirectToAction("Index");
        }

		public IActionResult DepartmanSil(int id)
		{
			var dep = Con.Departments.Find(id);
			if (dep == null)
				return NotFound();

			Con.Departments.Remove(dep);
			Con.SaveChanges();
			return RedirectToAction("Index");
		}

        public IActionResult DepartmanGetir(int id)
		{
			var department = Con.Departments.Find(id);
            return View(department);
		}

        public IActionResult DepartmanGuncelle(Department dep)
        {
            var department = Con.Departments.Find(dep.Id);
            if (department == null)
                return NotFound();

            department.DepartmentName = dep.DepartmentName;
			Con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
