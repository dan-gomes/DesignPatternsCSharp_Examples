using Factory.Interfaces;
using System;

namespace Factory.Services
{
    /// <summary>
    /// Class responsible for delegating the subclass to be used.
    /// </summary>
    public class SchoolFactory : ISchoolFactory
    {
        public ISchoolFactory Create(string Location)
        {
            throw new NotImplementedException();
        }

        public ISchoolFactory Register(string Location, Type shcoolRepository)
        {
            throw new NotImplementedException();
        }
    }
}
