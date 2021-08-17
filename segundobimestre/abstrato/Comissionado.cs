namespace segundo_c.abstrato
{
  public class Comissionado : Empregado
  {
    public double totalVenda;
    private double taxaComissão;

    public Comissionado(string nome, string sobrenome, string cpf) : base(nome, sobrenome, cpf)
    {
    }

    public override double salario() => (this.totalVenda * this.taxaComissão);

	public void somarVenda(double valor) => this.totalVenda=+valor;

  }
}