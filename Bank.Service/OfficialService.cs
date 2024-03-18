using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    public class OfficialService: IOfficialService
    {
        private readonly IOfficialRepository _officialRepository;
        public OfficialService(IOfficialRepository officialRepository)
        {
            _officialRepository = officialRepository;
        }
        public async Task<IEnumerable<Official>> GetOfficialsAsync()
        {
        return await _officialRepository.GetOfficialsAsync();
         }


      public async Task<Official> GetOfficialByIdAsync(int id)
        {
            return await _officialRepository.GetOfficialByIdAsync(id);
        }
       public async Task<Official> AddOfficialAsync(Official official)
        {
            return  await _officialRepository.AddOfficialAsync(official);
        }
      public async Task<Official> UpdateOfficialAsync(int id, Official official)
        {
            return await _officialRepository.UpdateOfficialAsync(id, official);    
        }
      public  async Task DeleteOfficialAsync(int id)
        {
           await _officialRepository.DeleteOfficialAsync(id);
        }

    }
}
