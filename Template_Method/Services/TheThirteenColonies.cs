using Template_Method.Interfaces;

namespace Template_Method.Services
{
    /// <summary>
    /// Class <see cref="TheThirteenColonies"/> is responsible for implementing o Template Method
    /// through polymophism.
    /// </summary>
    public abstract class TheThirteenColonies : ITheThirteenColonies
    {
        /// <summary>
        /// Method that will access the overloaded methods in the child classes.         
        /// </summary>
        /// <returns></returns>
        public (int, string) GetByState()        
            => (Population(), Description());

        /// <summary>
        /// Method overloaded by child class. 
        /// </summary>
        /// <returns></returns>
        public abstract string Description();

        /// <summary>
        /// Method overloaded by child class. 
        /// </summary>
        /// <returns></returns>
        public abstract int Population();       
    }
}
