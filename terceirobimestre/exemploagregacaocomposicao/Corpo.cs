namespace terceirobimestre.exemploagregacaocomposicao
{
    public class Corpo
    {
        public Cabeca cabeca;
        public Braco braco;
        public Perna perna;
        public Corpo(){
          this.cabeca = new Cabeca();
          this.braco = new Braco();
          this.perna = new Perna();
        }
    }
}