using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public IEnumerable<User> GetAdults()
        {
            return _entities.Where(e => e.Age > 18).ToList();
        }
    }
}
