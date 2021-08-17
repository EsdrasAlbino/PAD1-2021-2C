namespace segundo_c.abstrato
{
  public class TV : Eletronico
  {
      public int polegada;
      public int canal;
    public TV(bool status, double voltagem, double consumo) : base(status, voltagem, consumo)
    {
    }

    public override void desligar() {}

    public override void ligar()
    {
      this.status = true;
      this.canal = 12;
    }

  }
}