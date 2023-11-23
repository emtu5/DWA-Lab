using daw_lab4.ContextModels;
using daw_lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace daw_lab4.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly StiriContext _stiriContext;
        public NewsRepository(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }
        async Task<IEnumerable<Stire>> INewsRepository.GetStiriAsync()
        {
            return await _stiriContext.Stire.ToListAsync();
        }

        async Task<Stire> INewsRepository.GetStireAsync(int id, bool includeCategories)
        {
            if (includeCategories)
            {
                return await _stiriContext.Stire.Include(s => s.Categorie).FirstOrDefaultAsync(s => s.Id == id);
            }

            return await _stiriContext.Stire.FirstOrDefaultAsync(s => s.Id == id);
        }

        async Task<Stire> INewsRepository.PostAsync(Stire stire)
        {
            _stiriContext.Add(stire);
            await _stiriContext.SaveChangesAsync();
            return stire;
        }
    }
}
