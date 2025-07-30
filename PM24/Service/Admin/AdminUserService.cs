using PM24.Models.Admin;
using PM24.Models.Entity;
using PM24.Context;             // Контекст
using Microsoft.EntityFrameworkCore;
using PM24.Interfaces;
using System.Data;
using System.Reflection.Metadata.Ecma335;



public class AdminUserService : IAdminUserService
{
    private readonly AppDbContext _db;

    public AdminUserService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<bool> CreateAsync(AdminUserDto dto)
    {
        // Проверь почту асинхронно!
        // if (await _db.AdminUsers.AnyAsync(x => x.Email == dto.Email))
        //     return false;

        var entity = new AdminUser
        {
            FullName = dto.FullName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            PasswordHash = dto.PasswordHash,
            IsActive = dto.IsActive,
            CreatedAt = DateTime.Now,
            LastLogin = DateTime.Now,
        };

        _db.AdminUsers.Add(entity);
        await _db.SaveChangesAsync();

        return true;
    }
}
