namespace Template_Method.Interfaces
{
    /// <summary>
    /// This interface is implemented in the parent class <see cref="Template_Method.Services.TheThirteenColonies"/> 
    /// in order to use method <see cref="GetByState()"/> by calling overloaded methods
    /// </summary>
    public interface ITheThirteenColonies
    {
        public (int, string) GetByState();
    }
}
