using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Util;
using Microsoft.Extensions.Configuration;

namespace BlueModasApi.Business.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken()
        {
            var token = TokenUtil.GenerateToken(_configuration.GetSection("Token:Secret").Value, _configuration.GetSection("Token:Name").Value);

            return token;
        }
    }
}
