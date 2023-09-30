
namespace CoreERPProj.Models.Jwt.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
