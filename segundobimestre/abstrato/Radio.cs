namespace segundo_c.abstrato
{
  public class Radio : Eletronico
  {
    public const int AM = 1;
    public const int FM = 2;
    public string banda;
    public double sintonia;
    public int volume;

    public Radio(bool status, double voltagem, double consumo) : base(status, voltagem, consumo)
    {
    }

    public override void desligar()
    {
      this.status = false;
      this.volume = 0;
    }

    public override void ligar()
    {
      this.status = true;
      this.sintonia = 88.1;
      this.volume = 10;
    }
  }
}