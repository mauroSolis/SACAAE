﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using SACAAE.Models;
using SACAAE.Helpers;

namespace SACAAE.Controllers
{
    /// <summary>
    /// Controlador encargado del inicio de sesión y el manejo de los usuarios.
    /// </summary>
    [Authorize]
    public class AccountController : Controller
    {
        public ProveedorMembersia MembershipService { get; set; }
        private RepositorioPeriodos RepoPeriodos = new RepositorioPeriodos();

        protected override void Initialize(RequestContext requestContext)
        {
            if (MembershipService == null)
                MembershipService = new ProveedorMembersia();

            base.Initialize(requestContext);
        }

        //
        // GET: /Account/LogOn
        [AllowAnonymous]
        public ActionResult Login()
        {
            List<String> Periodos = new List<String>();
            IQueryable<Periodo> ListaPeriodos = RepoPeriodos.ListaPeriodos();
            foreach (var item in ListaPeriodos)
            {
                Periodos.Add(item.Nombre);
            }
            ViewBag.Periodos = Periodos;
            return View();
        }

        //
        // POST: /Account/LogOn
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            List<String> Periodos = new List<String>();
            IQueryable<Periodo> ListaPeriodos = RepoPeriodos.ListaPeriodos();
            foreach (var item in ListaPeriodos)
            {
                Periodos.Add(item.Nombre);
            }
            ViewBag.Periodos = Periodos;


            if (ModelState.IsValid)
            {
                if (MembershipService.ValidateUser(model.NombreUsuario, model.Contrasenia))
                {
                    FormsAuthentication.SetAuthCookie(model.NombreUsuario, model.Recordarme);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Profesor");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Nombre de usuario y/o contraseña incorrectos.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }

        //
        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    /*string username, string fullName, string password, string email*/
                    MembershipService.CreateUser(model.UserName, model.Name, model.Password, model.Email);

                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                catch (ArgumentException ae)
                {
                    ModelState.AddModelError("", ae.Message);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePassword
        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword
        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
                    return RedirectToAction("ChangePasswordSuccess");
                else
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess
        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }
    }
}
