using eksamn_project.Server.Models;
using eksamn_project.Server.Models.DTOs;

namespace eksamn_project.Server.Services
{
    public interface IoverenskomstService
    {
        //code modified from https://stackoverflow.com/questions/14458566/making-interface-implementations-async
        public Task<List<string>> GetOverenskomstByGender(string gender);
        public Task<OverenskomstDTO> GetOvernsKomstByName(string name);
        
    }
}
