using APIOgVueAvslutning.Models;
using Microsoft.EntityFrameworkCore;

namespace APIOgVueAvslutning.Services
{
    public class CoockiesInfo : ICoockiesInfo
    {
        private readonly CoockiesDBContext _context;
        public CoockiesInfo(CoockiesDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Coockies>> GetCoockies()
        {
            return await _context.Coockies.Include(c => c.Ingredients).ToListAsync();
        }

        public async Task<Coockies> getCoockieById(int id)
        {
            return await _context.Coockies.Include(c => c.Ingredients).Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
