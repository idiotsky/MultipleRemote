using Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

public class IndexPageModel : PageModel
{
    private readonly IUserService m_userService;

    public IndexPageModel(IUserService userService)
    {
        m_userService = userService;
        Users = new List<User>();
    }

    public IList<User> Users { get; set; }
    public void OnGet()
    {
        Users = m_userService.LoadAll();
    }
}
