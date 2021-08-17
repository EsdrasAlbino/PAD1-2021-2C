namespace segundo_c.heranca
{
  public class Lucas : Gerson
  {
    public double altura;

    public Lucas(string nome, int idade, double altura) 
        : base(nome, idade)
    {
        this.altura = altura;
    }

    public void pular()
    {
      System.Console.WriteLine("Lucas pulando");
    }

    public override void falar()
    {
      System.Console.WriteLine("Agora é o Lucas falando!");
    }
  }
}