using eksamn_project.Server.Data;
using eksamn_project.Server.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace eksamn_project.Server.Services
{
    public class OverenskomstService
    {
        private readonly AppDbContext _context;

        public OverenskomstService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<string>> GetOverenskomstByGender(string gender)
        {
            List<string> strings = new List<string>();
            var overnskomst = await _context.overenskomsts
                .Where(o => o.Gender == gender)
                .ToListAsync();
            if (overnskomst != null)
            {
                foreach (var o in overnskomst) 
                { 
                    strings.Add(o.Name);      
                }
                return strings;
            }
            else
            {
                return null;
            }
        }

        public async Task<OverenskomstDTO> GetOvernsKomstByName( string name)
        {
            var overnskomst = await _context.overenskomsts
                .Where(o  => o.Name == name)
                .FirstOrDefaultAsync();
            if (overnskomst != null) 
            {
                return new OverenskomstDTO
                {
                    Name = overnskomst.Name,
                    MaternityAmountByWeeks = overnskomst.MaternityAmountByWeeks
                };            
            }
            else
            {
                return null;
            }
        }

    }
}
