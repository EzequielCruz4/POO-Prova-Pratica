# Quinta Questao

Codigo da Quinta Questao

using System;
using System.Collections.Generic;

// interface IAnimal com o método EmitirSom()
interface IAnimal
{
    void EmitirSom();
}

// classe Cachorro implementando IAnimal
class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Cachorro: Au Au!");
    }
}

// classe Gato implementando IAnimal
class Gato : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Gato: Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // lista de animais usando a interface IAnimal
        List<IAnimal> animais = new List<IAnimal>();

        // adicionando instâncias de Cachorro e Gato
        animais.Add(new Cachorro());
        animais.Add(new Gato());

        // percorrendo a lista e chamando EmitirSom()
        foreach (IAnimal animal in animais)
        {
            animal.EmitirSom(); // a loucura do polimorfismo em ação
        }

        // aguarda o usuário pressionar uma tecla antes de encerrar pra nós vermos as coisas acontecendo
        // a Real é que eu queria ter feito realmente com uma interface e não só o console e a teoria mas, é oque temos pra hoje :D
        Console.ReadKey();
    }
}
