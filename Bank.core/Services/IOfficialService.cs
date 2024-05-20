using Bank.Entities;


namespace Bank.Core.Services
{
    public interface IOfficialService
    {
        Task<IEnumerable<Official>> GetOfficialsAsync();

        Task<Official> GetOfficialByIdAsync(int id);
        Task<Official> AddOfficialAsync(Official official);
        Task<Official> UpdateOfficialAsync(int id, Official official);
        Task DeleteOfficialAsync(int id);

    }
}
