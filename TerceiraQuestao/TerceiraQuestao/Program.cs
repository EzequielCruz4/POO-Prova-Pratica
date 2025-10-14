using System;

namespace Encapsulamento
{
    // classe que representa uma conta bancária 
    public class ContaBancaria
    {
        // o atributo privado que armazena o saldo
        private decimal _saldo;

        // a propriedade pública que expõe o saldo com apenas leitura
        // não permite valores negativos diretamente
        public decimal Saldo
        {
            get { return _saldo; } // pra permitir leitura
            private set             // só a própria classe pode alterar
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    Console.WriteLine("Erro: O saldo não pode ser negativo.");
                }
            }
        }

        // aqui o método para depositar um valor na conta
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro: O valor do depósito deve ser positivo.");
            }
        }

        // agora o método para sacar um valor da conta
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: O valor do saque deve ser positivo.");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Erro: Saldo insuficiente para saque de R$ {0:F2}.", valor);
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // criando uma nova conta bancária
            ContaBancaria conta = new ContaBancaria();

            // realizando algumas operações pra mostrar 
            conta.Depositar(100000);      // depósito válido
            conta.Sacar(10000);           // saque válido (mentira da porra)
            conta.Sacar(1);          // saque maior que o saldo
            conta.Depositar(-5231);       // depósito inválido
            conta.Sacar(1);           // saque inválido, seu liso

            // exibindo o saldo final
            Console.WriteLine($"\nSaldo atual: R$ {conta.Saldo:F2}");

            // aguarda tecla para fechar pra nós vizualizarmos né
            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
