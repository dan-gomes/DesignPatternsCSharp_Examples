using Factory.DTO;
using Factory.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Factory.Repositories
{
    /// <summary>
    /// Subclass with their own implementation of school chores.
    /// </summary>
    public class WestSchoolRepository : ISchoolRepository
    {
        public Task<SchoolAverage> ConsultAverage()
          => Task.FromResult<SchoolAverage>(new SchoolAverage
          {
              AgeRangeOfStudents = 16,
              NumberOfStudents = 70
          });
    }
}
