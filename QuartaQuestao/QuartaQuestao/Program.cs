using System;

namespace VeiculosApp
{
    // classe abstrata que define um contrato para veículos
    abstract class Veiculo
    {
        // o método abstrato: quem herdar essa classe será obrigado a implementar esse método
        public abstract int CalcularVelocidadeMaxima();
    }

    // a classe Moto que herda da classe Veiculo
    class Moto : Veiculo
    {
        // aqui a gente implementa a lógica específica para Moto
        public override int CalcularVelocidadeMaxima()
        {
            // o valor fictício de velocidade máxima para exemplo
            return 500000; // km/h
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // aqui criamos uma instância da classe Moto
            Moto minhaMoto = new Moto();

            // dai chamamos o método para calcular a velocidade máxima
            int velocidadeMaxima = minhaMoto.CalcularVelocidadeMaxima();

            // e exibimos o resultado no console
            Console.WriteLine("A velocidade máxima da moto é só de: " + velocidadeMaxima + " km/h");

            // aguarda o usuário pressionar uma tecla antes de encerrar, só pra ver né chefe
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
