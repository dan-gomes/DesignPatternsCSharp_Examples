using Factory.Interfaces;
using Factory.Repositories.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Factory.Services
{
    /// <summary>
    /// Class responsible for delegating the subclass to be used.
    /// </summary>
    public class SchoolFactory : ISchoolFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDictionary<string, Type> _repository = new Dictionary<string,Type>();

        public SchoolFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public ISchoolFactory Register(string location, Type shcoolRepository)
        {
            if (_repository.TryAdd(location,shcoolRepository))
                _repository[location] = shcoolRepository;

            return this;            
        }
        public ISchoolRepository Create(string location)
        {
            ISchoolRepository result = null;

            if (_repository.TryGetValue(location, out Type type))            
                result = _serviceProvider.GetService(type) as ISchoolRepository;
            
            return result;
        }
    }
}
