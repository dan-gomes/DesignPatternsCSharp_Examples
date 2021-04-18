using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class CommonwealthofPennsylvaniaRepository : TheThirteenColonies
    {
        public override string Description()
         => "A Pensilvânia, um estado no nordeste dos EUA e uma das 13 colônias originais do país, " +
            "tem um relevo diverso que inclui amplas áreas de fazendas, florestas nacionais e montanhas";

        public override int Population()
         => 12800000;
    }
}
