﻿using Jwt.Models;

namespace Jwt.Services
{
    public interface IAuthServices
    {
        Task<AuthModel>RegisterAsync (RegisterModel model);
        Task<AuthModel>GetTokenAsync (TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
