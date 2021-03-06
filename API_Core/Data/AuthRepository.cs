using System.Threading.Tasks;
using INK_API.Models;
using Microsoft.EntityFrameworkCore;

namespace INK_API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }
        
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        // private RefreshToken CreateRefreshToken()
        // {
        //     var randomNumber = new byte[32];
        //     using(var generator = new RNGCryptoServiceProvider())
        //     {
        //         generator.GetBytes(randomNumber);
        //         return new RefreshToken
        //         {
        //             Token = Convert.ToBase64String(randomNumber),
        //             Expires = DateTime.UtcNow.AddDays(10),
        //             Created = DateTime.UtcNow
        //         };
        //     }
        // }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)) ;
            }
        }
    }
}