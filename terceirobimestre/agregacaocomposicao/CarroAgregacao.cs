namespace terceirobimestre.agregacaocomposicao
{
    public class CarroAgregacao
    {
        public string modeloCarro;
        public Porta pEsq = new Porta("azul");
        public Porta pDir = new Porta("azul");
        public Motor motor = new Motor(1.6);

        public CarroAgregacao(string m){ 
          this.modeloCarro=m; 
        }
    }
}