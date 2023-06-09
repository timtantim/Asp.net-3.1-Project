﻿using IdentityModel.Client;
using System.Threading.Tasks;

namespace NttProject1.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
