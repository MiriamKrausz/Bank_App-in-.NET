using Bank.Entities;

namespace Bank.Core.Repositories
{
    public interface IOfficialRepository
    {
        Task<IEnumerable<Official>> GetOfficialsAsync();

        Task<Official> GetOfficialByIdAsync(int id);
        Task<Official> AddOfficialAsync(Official official);
        Task<Official> UpdateOfficialAsync(int id, Official official);
        Task DeleteOfficialAsync(int id);

    }
}
