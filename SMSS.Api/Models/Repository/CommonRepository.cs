using Microsoft.EntityFrameworkCore;
using SMSS.Api.Data;
using SMSS.Api.Models.Interface;
using SMSS.Models;

namespace SMSS.Api.Models.Repository
{
    public class CommonRepository : ICommonService
    {
        private SMSSContext context;

        public CommonRepository(SMSSContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<States>> GetStates()
        {
            var result = await context.States.ToListAsync();
            return result;
        }
    }
}
