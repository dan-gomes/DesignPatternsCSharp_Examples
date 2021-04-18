using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class VirginiaRepository : TheThirteenColonies
    {
        public override string Description()
         => "A Virgínia, um estado no sudeste dos EUA, estende-se desde a " +
            "Baía de Chesapeake até os Apalaches, com um longo litoral no Oceano Atlântico";

        public override int Population()
         => 8536000; 
    }
}
