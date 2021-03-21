﻿using Factory.Repositories.Interfaces;
using System;

namespace Factory.Interfaces
{
    /// <summary>
    /// Interface for factory implementatiton.
    /// </summary>
    public interface ISchoolFactory
    {
        public ISchoolRepository Register(string Location, Type shcoolRepository);
        public ISchoolRepository Create(string Location);
    }
}
