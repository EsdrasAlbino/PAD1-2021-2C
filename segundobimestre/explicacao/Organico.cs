namespace segundo_c.explicacao
{
  public class Organico : Produto
  {
    private int validade;
    public Organico(string descricao, double valor, int estoque, int validade) : base(descricao, valor, estoque)
    {
      this.validade = validade;
    }
    public int Validade { get => validade; set => validade = value; }
    public int PrasoValidade()
    {
      return Validade * Estoque;
    }
    public override void imprimirDados(string msg)
    {
      // base.imprimirDados(msg);
    }

    public void VerificarValidade() {
      if(validade != 0) {
        System.Console.WriteLine("produto bom para consumo!");
      } else {
        System.Console.WriteLine("produto estragado!");
      }
    }
  }
}