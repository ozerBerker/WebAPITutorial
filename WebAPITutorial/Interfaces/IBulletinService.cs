using WebAPITutorial.Models;

namespace WebAPITutorial.Interfaces
{
    public interface IBulletinService
    {
        IEnumerable<Bulletin> GetAll();
    }
}
