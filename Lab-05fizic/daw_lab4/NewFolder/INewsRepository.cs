using daw_lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace daw_lab4.Repositories
{
    public interface INewsRepository
    {
        Task<IEnumerable<Stire>> GetStiriAsync();
        Task<Stire> GetStireAsync(int id, bool includeCategories);
        Task<Stire> PostAsync(Stire stire);
    }
}
