namespace segundo_c.explicacao
{
  // texto de teste de envio para o git
  public class Produto
  {
    private string descricao;
    private double valor;
    private int estoque;
    public Produto(string descricao, double valor, int estoque)
    {
      this.Descricao = descricao;
      this.Valor = valor;
      this.Estoque = estoque;
    }
    public string Descricao { get; set; }
    public double Valor { get => valor; set => valor = value; }
    public int Estoque { get => estoque; set => estoque = value; }
    public virtual void imprimirDados(string msg) {
      System.Console.WriteLine(msg);
    }
  }
}