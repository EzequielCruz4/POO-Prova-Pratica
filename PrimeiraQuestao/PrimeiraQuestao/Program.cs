using System;

namespace ProvaPraticaPOO
{
    // a classe Livro com encapsulamento
    class Livro
    {
        // aqui os tributos privados
        private string _titulo;
        private string _autor;

        // propriedade pública para Titulo, tem que ter né
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                // Validação simples, vapo
                if (!string.IsNullOrWhiteSpace(value))
                    _titulo = value;
                else
                    Console.WriteLine("Título inválido!");
            }
        }

        // e também a propriedade pública para Autor
        public string Autor
        {
            get { return _autor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _autor = value;
                else
                    Console.WriteLine("Autor inválido!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // aqui a criação de um objeto da classe Livro
            Livro livro1 = new Livro();

            // a atribuição de valores através das propriedades
            livro1.Titulo = "O Senhor das Lambadas";
            livro1.Autor = "Ezequiel da Lambada";

            // aqui a exibição das informações do livro
            Console.WriteLine("Informações do Livro:");
            Console.WriteLine("Título: " + livro1.Titulo);
            Console.WriteLine("Autor: " + livro1.Autor);

            // e aqui ele aguarda o usuário pressionar uma tecla antes de fechar
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

