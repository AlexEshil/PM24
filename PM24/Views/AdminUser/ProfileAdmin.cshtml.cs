using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PM24.Views.AdminUser
{
    public class ProfileAdmin : PageModel
    {
        private readonly ILogger<ProfileAdmin> _logger;

        public ProfileAdmin(ILogger<ProfileAdmin> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}