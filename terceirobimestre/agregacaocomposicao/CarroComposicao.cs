namespace terceirobimestre.agregacaocomposicao
{
    public class CarroComposicao
    {
      public string modeloCarro;
      public Porta pEsq, pDir;
      public Motor motor;
      public CarroComposicao (string m, string c, double p){
        this.modeloCarro = m;
        pEsq = new Porta(c);
        pDir = new Porta(c);
        motor = new Motor(p);
      }
    }
}