using Factory.DTO;
using Factory.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Factory.Repositories
{
    /// <summary>
    /// Subclass with their own implementation of school chores.
    /// </summary>
    public class SouthShoolRepository : ISchoolRepository
    {
        public Task<SchoolAverage> ConsultAverage(string location)
        {
            throw new System.NotImplementedException();
        }
    }
}
