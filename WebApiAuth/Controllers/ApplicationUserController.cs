using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLog;
using WebApiAuth.Dto;
using WebApiAuth.Models;
using WebApiAuth.Services;
using WebApiAuth.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAuth.Controllers
{
    [Route("api/applicationUser")]
    public class ApplicationUserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        //private static Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly ILoggerManager _logger;
        public ApplicationUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            ILoggerManager logger)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: api/<controller>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]ApplicationUserViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = new ApplicationUser
            {
                UserName = model.UserName,
                FullName = model.FullName,
                Email = model.Email
            };

            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception throw while register: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}
