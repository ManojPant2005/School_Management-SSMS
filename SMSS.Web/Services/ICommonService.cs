using SMSS.Models;

namespace SMSS.Web.Services
{
    public interface ICommonService
    {
        Task<IEnumerable<States>> GetStates();
    }
}
