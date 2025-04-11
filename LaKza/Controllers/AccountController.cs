using LaKza.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using LaKza.ViewModels;

namespace LaKza.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<Usuario> _singInManager;
    private readonly UserManager<Usuario> _userManager;
    private readonly IWebHostEnvironment _host;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<Usuario> singInManager,
        UserManager<Usuario> userManager,
        IWebHostEnvironment host
    )
    {
        _logger = logger;
        _singInManager = singInManager;
        _userManager = userManager;
        _host = host;

    }
    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }
}