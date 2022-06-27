using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using News.Convertor;
using News.Core.Convertor;
using News.Core.DTOs;
using News.Core.Generator;
using News.Core.Security;
using News.Core.Senders;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.User;

namespace News.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRender;
        public AccountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
        }
        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");
                return View(register);
            }

            if (_userService.IsExistEmail(FixedText.FixedEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتبر نمی باشد");
                return View(register);
            }

            User user = new User()
            {
                UserName = register.UserName,
                Email = register.Email,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                ActiveCode = NameGenerator.GenerateUniqCode(),
                IsActive = true,
                RegisterDate = DateTime.Now
            };

            _userService.AddUser(user);

            #region Send Activation Email
            //try
            //{
            //    string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            //    SendEmail.Send(user.Email, "فعالسازی", body);
            //}
            //catch
            //{

            //}
            #endregion
            return View("SuccessRegister", user);
        }
        #endregion

        #region Login
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var user = _userService.LoginUser(login);
            if (user != null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>
                     {
                       new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                       new Claim(ClaimTypes.Name, user.UserName),
                        //new Claim("CodeMeli", user.Email),

                     };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };

                    HttpContext.SignInAsync(principal, properties);
                    ViewBag.IsSuccess = true;
                    return View();
                }
            }
            ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد");
            return View(login);
        }
        #endregion

        #region ActicveAccount
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }
        #endregion

        #region Logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion

        #region password
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }

            try
            {
                string fixedEmail = FixedText.FixedEmail(forgot.Email);
                User user = _userService.GetUserByEmail(fixedEmail);
                if (user == null)
                {
                    ModelState.AddModelError("Email", "کاربری یافت نشد");
                    return View(forgot);
                }

                string body = _viewRender.RenderToStringAsync("_ForgotPassword", user);
                SendEmail.Send(user.Email, "بازیابی کلمه عبور", body);
                ViewBag.IsSuccess = true;
            }
            catch
            {
                ViewBag.IsSuccess = false;
            }
            return View();
        }
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {
                ActiveCode = id
            });
        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
            {
                return View(reset);
            }

            User user = _userService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
            {
                return NotFound();
            }

            string hashPassword = PasswordHelper.EncodePasswordMd5(reset.Password);

            user.Password = hashPassword;
            _userService.UpdateUser(user);

            return Redirect("/Login");
        }
        #endregion
    }
}