# Segunda Questao

codigo da segunda questao

using System;
using System.Collections.Generic;

namespace HerancaPolimorfismo
{
    // classe base que representa um funcionario aleatorio da empresa
    public class Funcionario
    {
        // propriedade que armazena o nome do funcionario né
        public string Nome { get; set; }

        // aqui é o construtor que recebe
        public Funcionario(string nome)
        {
            Nome = nome;
        }

        // O metodo virtual que pode ser sobescrito pelas classes derivadas
        public virtual void Trabalhar()
        {
            Console.WriteLine($"{Nome} está realizando tarefas gerais de funcionário.");
        }
    }

    // classe derivada que representa o gerente e herda do funcionario 
    public class Gerente : Funcionario
    {
        // o construtor da classe gerente
        public Gerente(string nome) : base(nome)
        {
        }

        // sobrescreve o metodo trabalhar 
        public override void Trabalhar()
        {
            Console.WriteLine($"{Nome} está gerenciando a equipe e planejando estratégias.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // funcionario comum
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Funcionario("Carlos"),     // funcionario comum
                new Gerente("Ana"),            // gerente
                new Funcionario("Marcos"),     // outro escr... digo, funcionario comum
                new Gerente("Fernanda")        // outra gerente que trabalhar dms slk
            };

            // aqui a gente usa o polimorfiso com outro metodo
            foreach (Funcionario f in funcionarios)
            {
                f.Trabalhar();  // o metodo depende do objeto
            }

            // pausazinha pra visualizar as coisas no console
            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
