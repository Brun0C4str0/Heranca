using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HerançaC_
{

}
public class Teste
{
    public class Pessoa
    {
        public string nome { set; get; }
        public int idade { set; get; }
        public virtual void comer(string alimento)
        {
            Console.WriteLine("A Pessoa comendo {0}", alimento);
        }
    }
    public class Sergio : Pessoa
    {
        public override void comer(string alimento)
        {
            if (alimento == "peixe")
                Console.WriteLine("Sérgio não gosta de peixe. Não vai comer.");
            else
                base.comer(alimento); //base chama o método pai
        }
    }
    public static void Main()
    {
        string comida;
        Pessoa teste = new Pessoa();
        Console.Write("Qual comida você dará a Pessoa e Sergio? ");
        comida = Console.ReadLine();
        teste.comer(comida);
        Sergio teste3 = new Sergio();
        teste3.comer(comida);
        Console.ReadLine();
    }
}