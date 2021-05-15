using BlogTrybe.Core.Services;
using System;

namespace BlogTrybe.Infrastructure.Auth
{
    public class AuthService : IAuthService
    {
        public string ComputeSha256Hash(string password)
        {
            throw new NotImplementedException();
        }

        public string GenerateJwtToken(string email)
        {
            throw new NotImplementedException();
        }
    }
}
