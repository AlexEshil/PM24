using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PM24.Interfaces;
using PM24.Models.Admin;

namespace PM24.Controllers
{
   public class AdminUserController : Controller
    {
        private readonly IAdminUserService _adminUserService;
        public AdminUserController(IAdminUserService adminUserService)
        {
            _adminUserService = adminUserService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new AdminUserDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdminUserDto model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _adminUserService.CreateAsync(model);
            if (!result)
            {
                ModelState.AddModelError("Email", "Пользователь с такой почтой уже зарегистрирован!");
                return View(model);
            }
            return RedirectToAction("Success");
          }

        public IActionResult Success()
        {
            return Content("Админ успешно создан!");
        }
}



}