using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class RhodeIslandRepository : TheThirteenColonies
    {
        public override string Description()
         => "Rhode Island, oficialmente State of Rhode Island and Providence Plantations é um dos 50 estados dos Estados Unidos";

        public override int Population()
         => 1059000;
    }
}
