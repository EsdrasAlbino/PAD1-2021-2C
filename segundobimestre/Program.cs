using System;
// using segundo_c.encapsulamento;
using segundo_c.heranca;
using segundo_c.interfaces;
using segundo_c.abstrato;
using segundo_c.explicacao;

namespace segundo_c
{
  class Program
  {
    static void Main(string[] args)
    {
      // encapsulamento();
      // heranca();
      // ComInterfaces();
      // abstrato();
      // explicacao();
      interfaces();
    }

    public static void interfaces(){
      IRacional homem = new Animal();
      homem.falar();
      IIrracional cachorro = new Animal();
      cachorro.latir();
    }

    public static void explicacao() {
      Organico obj1 = new Organico("Maria Fernanda", 2.5, 1234, 5);
      obj1.imprimirDados("100");
    }
    public static void ComInterfaces()
    {
      //Observe que o objeto c pertence a interface Caixa, logo só poderá fazer uso dos métodos, propriedades e constantes declaradas na interface Caixa. Da mesma forma que o objeto g só poderá fazer uso do que foi liberado pela interface Gerente.
      ICaixa c = new Funcionario2_0("joaquim Silva", 1234567, 0, 1000.00);
      IGerente g = new Funcionario2_0("Rico D'Emery", "001-G", 1, 3000.00);
      //Chamada de método para exibir as informações dos funcionários
      c.getInformacaoFuncao();
      g.getInformacaoFuncao();
      // System.Console.WriteLine("RG do gerente: " + g.Rg);
    }
    public static void SemInterfaces()
    {
      //cria os objetos
      Funcionario a = new Funcionario("Joaquim Silva", 1234567, 0, 1000.00);
      Funcionario b = new Funcionario("Rico D'Emery", "001-G", 1, 3000.00);
      //chamada de método para exibir as informações dos funcionários
      a.getInformacaoFuncao();
      b.getInformacaoFuncao();
      //exemplo de instrução que utiliza um método que não deveria ser permitido
      System.Console.WriteLine("RG do gerente: " + b.Rg);
    }
    public static void abstrato()
    {
      Eletronico tv = new TV(false, 220.0, 100.0);
      Eletronico radio = new Radio(false, 220.0, 50.0);

      Console.WriteLine(tv.status);
      tv.ligar();
      Console.WriteLine(tv.status);
    }
    public static void heranca()
    {
      Gerson g = new Gerson("Gerson", 28);

      Lucas l = new Lucas("Lucas", 18, 12.2);

      g.falar();
      l.falar();

    }
    public static void encapsulamento()
    {
      // Produto p1 = new Produto("macarrão", 2.0, 20);

      // Produto p2 = new Produto();
      // p2.Description = "maçã";
      // p2.Value = 4.30;
      // p2.Storage = 55700;

      // Produto p3 = new Produto();
      // p3.Description = "arroz";
      // p3.Value = 2.30;
      // p3.Storage = 78;

      // Console.WriteLine(p2.Description);
      // Console.WriteLine(p2.Value);
      // Console.WriteLine(p2.Storage);

      // Console.WriteLine(p3.Description);
      // Console.WriteLine(p3.Value);
      // Console.WriteLine(p3.Storage);
    }
  }
}
