namespace terceirobimestre.exemploagregacaocomposicao
{
    public class Boca
    {
      public Dentes dentes = new Dentes();
      public Lingua lingua;
      public Boca(){
        this.lingua = new Lingua();
      }
    }
}