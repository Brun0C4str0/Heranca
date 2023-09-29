using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaC_
{ public class Teste
    {
        public class Pessoa
        {
            public string nome { set; get; }
            public int idade { set; get; }
            public void comer(string alimento)
            {
                Console.WriteLine("A Pessoa comendo {0}", alimento);
            }
        }
        public class Luciana : Pessoa
        {
            public int sapato { get; set; }
            public void dormir()
            {
                Console.WriteLine("Luciana dormindo!");
            }
        }
        public class Sergio : Pessoa
        {
            public string Mestrado { get; set; }
        }
        public static void Main()
        {
            string comida;
            Pessoa teste = new Pessoa();
            Console.Write("Qual comida você dará a Pessoa? ");
            comida = Console.ReadLine();
            teste.comer(comida);
            Luciana teste2 = new Luciana();
            teste2.sapato = 37;
            teste2.comer(comida);
            Console.WriteLine("Luciana calça {0}.", teste2.sapato);
            Console.ReadLine();
        }
    }
}