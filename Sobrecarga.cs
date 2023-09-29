using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa()
    {
        Nome = "Sem Nome";
        Idade = 0;
    }

    public Pessoa(string nome)
    {
        Nome = nome;
        Idade = 0;
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

class Estudante : Pessoa
{
    public string Matricula { get; set; }

    public Estudante()
    {
        Matricula = "N/A";
    }

    public Estudante(string nome, int idade, string matricula) : base(nome, idade)
    {
        Matricula = matricula;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, sou o estudante {Nome}, tenho {Idade} anos e minha matrícula é {Matricula}.");
    }
}

class Program
{
    static void Main()
    {
        // Criando instâncias da classe Estudante usando diferentes construtores
        Estudante estudante1 = new Estudante();
        Estudante estudante2 = new Estudante("Alice", 20, "12345");

        // Chamando o método Apresentar da classe Estudante
        estudante1.Apresentar();
        estudante2.Apresentar();
    }
}



