using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pacifice_Website.Data;

namespace Pacifice_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,

            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
     
       
        [HttpGet]
        [AllowAnonymous]
        public IActionResult CreateRole()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole(string RoleName)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(RoleName))
            {
                if (await _roleManager.RoleExistsAsync(RoleName))
                {
                    msg = "Role " + RoleName + " Already exists";
                }
                else
                {
                    IdentityRole Role = new IdentityRole(RoleName);
                    await _roleManager.CreateAsync(Role);
                    TempData["create"] = "Role " + RoleName + " Successfully Created";

                }
                ViewBag.msg = msg;
                return View("CreateRole");
            }
            else
            {
                ViewBag.msg = "Please enter a valid role";
                return View("CreateRole");
            }

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AssignRole()
        {
            var users = _userManager.Users;
            var roles = _roleManager.Roles;

            ViewBag.userlist = users;
            ViewBag.rolelist = roles;
            ViewBag.msg = TempData["msg"];

            return View();
        }
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignRole(string appuser, string approle)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(appuser) && !string.IsNullOrEmpty(approle))
            {
                var user = await _userManager.FindByNameAsync(appuser);
                if (user != null)
                {
                    IdentityRole role = await _roleManager.FindByNameAsync(approle);
                    if (role != null)
                    {
                        await _userManager.AddToRoleAsync(user, role.Name);
                        msg = role.Name + " has been assigned to user {" + user.UserName + "}.";
                    }
                    else
                    {
                        msg = "Role cannot be empty to assign to user.";
                    }
                }
                else
                {
                    msg = "Please select a User to assign Role.";
                }
            }
            else
            {
                msg = "Invalid User and/or Invalid Role.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("AssignRole");

        }
        [Authorize(Roles = "Admin")]
        public IActionResult RegisteredUserIndex(string returnUrl = null)
        {
            var user = _context.Users.ToList();
            return View(user);
        }

    }
}
