namespace segundo_c.abstrato
{
  public abstract class Eletronico
  {
    public bool status;
    public double voltagem;
    public double consumo;

    protected Eletronico(bool status, double voltagem, double consumo)
    {
      this.status = status;
      this.voltagem = voltagem;
      this.consumo = consumo;
    }

    public abstract void ligar();
    public abstract void desligar();

    public bool isLigado() {
        return this.status;
    }
  }
}