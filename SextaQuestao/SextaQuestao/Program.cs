using System;

namespace SistemaLogistica
{
    // a classe abstrata representa um conceito geral de veículo
    abstract class Veiculo
    {
        // os atributos protegidos: acessíveis pelas classes derivadas
        protected string identificacao;
        protected double capacidade;

        // aqui as propriedades públicas para acessar/modificar os atributos protegidos
        public string Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }

        public double Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        // o método abstrato: será implementado nas classes que herdarem Veiculo
        public abstract string RegistrarEntrega(string destino, double carga);
    }

    // aqui a classe derivada Caminhao herda de Veiculo
    class Caminhao : Veiculo
    {
        // agora implementa o método abstrato da classe base
        public override string RegistrarEntrega(string destino, double carga)
        {
            // aqui pra validar se a carga não excede a capacidade do caminhão
            if (carga > capacidade)
            {
                return $"Erro: A carga ({carga}kg) excede a capacidade do caminhão ({capacidade}kg).";
            }

            // retorna os dados formatados da entrega
            return $"Entrega registrada com sucesso!\n" +
                   $"Veículo: {identificacao}\n" +
                   $"Capacidade: {capacidade} kg\n" +
                   $"Destino: {destino}\n" +
                   $"Carga: {carga} kg";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // aqui ele instancia um objeto da classe Caminhao
            Caminhao caminhao1 = new Caminhao();

            // e define os valores dos atributos via propriedades
            caminhao1.Identificacao = "Caminhão 01 - Optimus Prime";
            caminhao1.Capacidade = 10000; // 10.000 kg de capacidade

            // agora define destino e carga
            string destino = "Centro de Distribuição - Cybertron";
            double carga = 8500;

            // aqui ele chama o método RegistrarEntrega e exibe o resultado
            string resultadoEntrega = caminhao1.RegistrarEntrega(destino, carga);
            Console.WriteLine(resultadoEntrega);

            // e aguarda o usuário pressionar uma tecla antes de fechar para ver as coisas bonitinho
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
