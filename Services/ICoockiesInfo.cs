using APIOgVueAvslutning.Models;

namespace APIOgVueAvslutning.Services
{
    public interface ICoockiesInfo
    {
        Task<IEnumerable<Coockies>> GetCoockies();

        Task<Coockies> getCoockieById(int id);

        
    }
}
