using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class MassachusettsRepository : TheThirteenColonies
    {
        public override string Description()
         => "Massachusetts é um estado em New England, nos EUA, conhecido por sua importante história colonial.";

        public override int Population()
         => 6893000;
    }
}
