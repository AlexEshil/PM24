using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PM24.Models.Admin;
//using PM24.Service.Admin;

namespace PM24.Interfaces

{
    public interface IAdminUserService
    {
        Task<int> CreateAsync(AdminUserDto dto);
        Task<AdminUserDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(AdminUserDto model);
        Task<bool> DeleteAsync(int id);
    }
}