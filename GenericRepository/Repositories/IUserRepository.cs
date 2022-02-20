using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        public IEnumerable<User> GetAdults();
    }
}
