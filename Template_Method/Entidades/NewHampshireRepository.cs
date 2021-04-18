using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class NewHampshireRepository : TheThirteenColonies
    {
        public override string Description()
         => "New Hampshire, um estado dos EUA situado na região da Nova Inglaterra," +
            " é definido pelas cidades pitorescas e pelas grandes áreas selvagens";

        public override int Population()
         => 1360000;
    }
}
