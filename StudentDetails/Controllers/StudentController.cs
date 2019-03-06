using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Controllers
{
	public class StudentController : Controller
	{
		StudentStoreContext studentStoreContext;

		public StudentController(StudentStoreContext context)
		{
			studentStoreContext = context;

		}
		public IActionResult Index()
		{
			List<Student> Students = studentStoreContext.Students.ToList();
			return View(Students);
		}

		public IActionResult Detay(int id)
		{
			Student Student = studentStoreContext.Students.Where(b => b.Id == id).FirstOrDefault();
			if (Student != null)
			{
				return View(Student);
			}
			else
			{
				return NotFound();
			}
		}
	}

}

