using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class GeorgiaRepository : TheThirteenColonies
    {
        public override string Description()
         => "A Geórgia, um país na interseção da Europa com a Ásia, é uma antiga república soviética " +
            "com aldeias na cordilheira do Cáucaso e praias no Mar Negro";

        public override int Population()
        => 3720000;
    }
}
