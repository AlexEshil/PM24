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

    public async Task<int> CreateAsync(AdminUserDto dto)
    {
        // Проверь почту асинхронно!
        if (await _db.AdminUsers.AnyAsync(x => x.Email == dto.Email))
            return 0;

        var entity = new AdminUser
        {
            Id = dto.Id,
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

        return entity.Id;
    }
    //Ищем по Id
    public async Task<AdminUserDto?> GetByIdAsync(int id)
    {
        var admin = await _db.AdminUsers.FirstOrDefaultAsync(a => a.Id == id);
        if (admin == null)
            return null;
        return new AdminUserDto
        {
            Id = admin.Id,
            FullName = admin.FullName,
            Email = admin.Email,
            PhoneNumber = admin.PhoneNumber,
            IsActive = admin.IsActive,
            CreatedAt = admin.CreatedAt,
            LastLogin = admin.LastLogin,
            PasswordHash = admin.PasswordHash
        };

    }
    public async Task<bool> UpdateAsync(AdminUserDto model)
    {
        var admin = _db.AdminUsers.FirstOrDefault(a => a.Id == model.Id);
        if (admin == null)
            return false;

        admin.FullName = model.FullName;
        admin.Email = model.Email;
        admin.PhoneNumber = model.PhoneNumber;
        admin.IsActive = model.IsActive;
        admin.PasswordHash = model.PasswordHash;

        await _db.SaveChangesAsync();
        return true;


    }
    public async Task<bool> DeleteAsync(int id)
    {
        var admin = _db.AdminUsers.FirstOrDefault(a => a.Id == id);
        if (admin == null)
            return false;

        _db.AdminUsers.Remove(admin);
         await _db.SaveChangesAsync();

        return true;
    }
}
