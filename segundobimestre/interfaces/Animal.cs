namespace segundo_c.interfaces
{
  public class Animal : IIrracional, IRacional
  {
    public void falar()
    {
      System.Console.WriteLine("Homem falando");
    }
    public void latir()
    {
      System.Console.WriteLine("Cachorro latinho");
    }
  }
}