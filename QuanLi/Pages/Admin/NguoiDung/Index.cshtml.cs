using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using quanlyvanchuyencakoi.web3.Models;

namespace quanlyvanchuyencakoi.web3.Pages.Admin.NguoiDung
{
    public class IndexModel : PageModel
    {
		private readonly QuanlyContext _quanlyContext;

		public IndexModel(QuanlyContext quanlyContext)
		{
			_quanlyContext = quanlyContext;
		}

		public List<QlUser> users { get; set; }


		public async Task OnGetAsync()
		{
			if (_quanlyContext.Users != null)
			{
				users = await _quanlyContext.Users.ToListAsync();
			}
		}
	}
}
