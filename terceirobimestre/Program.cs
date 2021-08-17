using System;
using terceirobimestre.agregacaocomposicao;

namespace terceirobimestre
{
    class Program
    {
        static void Main(string[] args)
        {
          CarroComposicao carro = new CarroComposicao("Passeio", "Azul", 1.6);

          Console.WriteLine("Descrição do carro:\n"
          + "Modelo: " + carro.modeloCarro + "Cor da porta esquerda" + carro.pEsq.cor +
          "Potência do motor" + carro.motor.potencia);
        }
    }
}
