using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class ConnecticutRepository : TheThirteenColonies
    {
        public override string Description()
       => "Connecticut é um estado dos EUA, situado no sul da região da Nova Inglaterra," +
            " que apresenta uma mistura de cidades costeiras e áreas rurais repletas de pequenas cidades";

        public override int Population()
        => 3565000;
    }
}
