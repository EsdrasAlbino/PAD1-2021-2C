namespace terceirobimestre.exemploagregacaocomposicao
{
    public class Cabeca
    {
        public Boca boca;
        public Olhos olhos;
        public Cabelo cabelo = new Cabelo();
        public Orelha orelha;
        public Cabeca(){
          this.boca = new Boca();
          this.olhos = new Olhos();
          this.orelha = new Orelha();
        }
    }
}