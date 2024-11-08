﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using quanlyvanchuyencakoi.web3.Models;

namespace quanlyvanchuyencakoi.web3.Pages.Admin.NguoiDung
{
	public class EditModel : PageModel
	{
		private readonly QuanlyContext _context;

		// Inject the database context into the page model
		public EditModel(QuanlyContext context)
		{
			_context = context;
		}

		// Bind the user model to handle form data
		[BindProperty]
		public QlUser User { get; set; }

		// Load user data based on ID passed as a route parameter
		public async Task<IActionResult> OnGetAsync(int id)
		{
			User = await _context.Users.FindAsync(id);

			if (User == null)
			{
				return NotFound();
			}

			return Page();
		}

		// Handle form submission
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			var userInDb = await _context.Users.FindAsync(User.IdUser);
			if (userInDb == null)
			{
				return NotFound();
			}

			// Update user properties here
			userInDb.UserName = User.UserName;
			userInDb.Password = User.Password;
			userInDb.Email = User.Email;
			userInDb.PhoneNumber = User.PhoneNumber;
			userInDb.Name = User.Name;
			userInDb.Address = User.Address;
			userInDb.Access = User.Access;

			await _context.SaveChangesAsync();

			return RedirectToPage("./Index"); // Redirect to the index page after editing
		}
	}
}