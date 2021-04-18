using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class MarylandRepository : TheThirteenColonies
    {
        public override string Description()
         => "Maryland é um estado da região do Médio Atlântico dos Estados Unidos definido pelas hidrovias " +
            "e pelos litorais abundantes na Baía de Chesapeake e no Oceano Atlântico.";

        public override int Population()
         => 6046000;
    }
}
