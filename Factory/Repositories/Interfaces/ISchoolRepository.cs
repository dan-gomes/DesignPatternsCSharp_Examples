using Factory.DTO;
using System.Threading.Tasks;

namespace Factory.Repositories.Interfaces
{
    /// <summary>
    /// Interface for implemetation shcool choes.
    /// </summary>
    public interface ISchoolRepository
    {
        Task<SchoolAverage> ConsultAverage(string location);
    }
}
