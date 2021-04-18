using Template_Method.Services;

namespace Template_Method.Entidades
{
    public class NewJerseyRepository : TheThirteenColonies
    {
        public override string Description()
            => "Nova Jersey é um estado situado no nordeste dos EUA " +
            "com cerca de 130 milhas de costa no Oceano Atlântico";

        public override int Population()
         => 8882000;
    }
}
