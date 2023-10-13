using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skubbs_Test.Data;
using Skubbs_Test.Models;
using System;

namespace Skubbs_Test.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public EmployeeController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult List()
		{
			var employees = _context.Employees.ToList();
			return Json(employees);
		}

		[HttpPost]
		public IActionResult AddEmployee(Employee employee)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_context.Employees.Add(employee);
					_context.SaveChanges();
					return RedirectToAction("List");
				}
				catch (Exception ex)
				{
					ModelState.AddModelError(string.Empty, "An error occurred while adding the employee.");
					// Log the exception for debugging.
				}
			}
			return View("AddEmployeeView", employee); // Display the add employee view with validation errors.
		}

		[HttpPost]
		public IActionResult UpdateEmployee(Employee employee)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_context.Employees.Update(employee);
					_context.SaveChanges();
					return RedirectToAction("List");
				}
				catch (Exception ex)
				{
					ModelState.AddModelError(string.Empty, "An error occurred while updating the employee.");
					// Log the exception for debugging.
				}
			}
			return View("EditEmployeeView", employee); // Display the edit employee view with validation errors.
		}
	}
}
