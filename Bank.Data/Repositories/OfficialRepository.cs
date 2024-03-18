using Bank.Core.Repositories;
using Bank.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data.Repositories
{
    public class OfficialRepository : IOfficialRepository
    {
        private readonly DataContext _context;


        public OfficialRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<IEnumerable<Official>> GetOfficialsAsync()
        {
            return await _context.OfficialList.ToListAsync();
        }
        public async Task<Official> GetOfficialByIdAsync(int id)
        {
            return _context.OfficialList.Find(id);
        }
        public async Task<Official> AddOfficialAsync(Official official)
        {
            _context.OfficialList.Add(official);
            await _context.SaveChangesAsync();
            return official;
        }
        public async Task<Official> UpdateOfficialAsync(int id, Official official)
        {
            var updatedOfficial = _context.OfficialList.Find(id);
            //if (updatedOfficial == null)
            //    return null;
            updatedOfficial = official;
            await _context.SaveChangesAsync();
            return updatedOfficial;
        }
        public async Task DeleteOfficialAsync(int id)
        {
            _context.OfficialList.Remove(_context.OfficialList.Find(id));
            await _context.SaveChangesAsync();
        }
    }
}
