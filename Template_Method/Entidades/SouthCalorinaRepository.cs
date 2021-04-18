using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class SouthCalorinaRepository : TheThirteenColonies
    {
        public override string Description()
            => "A Carolina do Sul é um estado no sudeste dos EUA conhecido " +
            "pelo litoral de praias subtropicais e pelas pantanosas Sea Islands";

        public override int Population()
            => 5149000;
    }
}
