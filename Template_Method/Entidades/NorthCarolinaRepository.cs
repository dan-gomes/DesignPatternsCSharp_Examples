using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class NorthCarolinaRepository : TheThirteenColonies
    {
        public override string Description()
            => "A Carolina do Norte é um estado do sudeste dos EUA com uma paisagem " +
            "variada que inclui praias do Oceano Atlântico e a cordilheira dos Apalaches";

        public override int Population()
            => 10490000;
    }
}
