using Factory.Interfaces;
using Factory.Repositories.Interfaces;
using System;

namespace Factory.Services
{
    /// <summary>
    /// Class responsible for delegating the subclass to be used.
    /// </summary>
    public class SchoolFactory : ISchoolFactory
    {
        public ISchoolRepository Create(string Location)
        {
            throw new NotImplementedException();
        }

        public ISchoolRepository Register(string Location, Type shcoolRepository)
        {
            throw new NotImplementedException();
        }
    }
}
