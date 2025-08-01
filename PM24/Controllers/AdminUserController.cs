using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using PM24.Interfaces;
using PM24.Models.Admin;
using PM24.Models.Entity;

namespace PM24.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly IAdminUserService _adminUserService;
        public AdminUserController(IAdminUserService adminUserService)
        {
            _adminUserService = adminUserService;
        }
        //  форма регаем админа
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create", new AdminUserDto());
        }
        //готовый админ
        [HttpGet]
        public async Task<IActionResult> ProfileAdmin(int id)
        {
            var admin = await _adminUserService.GetByIdAsync(id);
            if (admin == null)
                return NotFound();
            return View("ProfileAdmin", admin);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var admin = await _adminUserService.GetByIdAsync(id);
            if (admin == null)
                return NotFound("Не найден");
            return View("Edit", admin);    
        }
        //регаем админа
        [HttpPost]
        public async Task<IActionResult> Create(AdminUserDto model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var adminId = await _adminUserService.CreateAsync(model);
            if (adminId == 0)
            {
                ModelState.AddModelError("Email", "Пользователь с такой почтой уже зарегистрирован!");
                return View(model);
            }

            //return RedirectToAction("Success");
            //return RedirectToAction("ProfileAdmin");
            return RedirectToAction("ProfileAdmin", new { id = adminId });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminUserDto model)
        {
            if (!ModelState.IsValid)
                return View("Edit", model);
            var update = await _adminUserService.UpdateAsync(model);
            if (!update)
            {
                ModelState.AddModelError("", "Ошибка при сохранении!");
                return View("Edit", model);
            }
            TempData["Message"] = "Сохранено!";
            return RedirectToAction("ProfileAdmin", new { id = model.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _adminUserService.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return RedirectToAction("Index");    
        }

        // public IActionResult Success()
        // {
        //     return Content("Админ успешно создан!");
        // }
    }
}