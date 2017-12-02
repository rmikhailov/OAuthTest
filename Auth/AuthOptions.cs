using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace OAuthTest.Web.Auth
{
    public static class AuthOptions
    {
        public const string Issuer = "OAuthTest.Web";
        public const string Audience = "http://localhost:5000/";
        private const string Key = "secret_secret_secret_secret_secret_secret_secret_secret_secret_secret";
        public const int Lifetime = 1; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        }
    }
}