using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class NewYorkRepository : TheThirteenColonies
    {
        public override string Description()        
            => "A cidade de Nova York compreende 5 distritos situados " +
            "no encontro do rio Hudson com o Oceano Atlântico";

        public override int Population()
            => 8419000;
    }
}
