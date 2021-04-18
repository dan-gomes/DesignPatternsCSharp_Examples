using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class DelawareRepository : TheThirteenColonies
    {
        public override string Description()
         => "Delaware é um dos 50 estados dos Estados Unidos, localizado na região nordeste";

        public override int Population()
         => 973764;
    }
}
