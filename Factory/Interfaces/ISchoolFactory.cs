using System;

namespace Factory.Interfaces
{
    /// <summary>
    /// Interface for factory implementatiton.
    /// </summary>
    public interface ISchoolFactory
    {
        public ISchoolFactory Register(string Location, Type shcoolRepository);
        public ISchoolFactory Create(string Location);
    }
}
