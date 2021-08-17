namespace segundo_c.abstrato
{
  public class Assalariado : Empregado
  {
    private double salary;
    public double Salary { get => salary; set => salary = value; }

    public Assalariado(string nome, string sobrenome, string cpf, double salary) : base(nome, sobrenome, cpf)
    {
        this.salary = salary;
    }

    public override double salario()
    {
      return this.Salary;
    }
  }
}