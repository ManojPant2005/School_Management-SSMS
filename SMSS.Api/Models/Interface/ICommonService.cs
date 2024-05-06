using SMSS.Models;

namespace SMSS.Api.Models.Interface
{
    public interface ICommonService
    {
        Task<IEnumerable<States>> GetStates();
    }
}
