using System;

namespace _3004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu?");
            int anoNasceu= int.Parse(Console.ReadLine());
            Console.WriteLine("Em qual mês você nasceu?");
            int mesNasceu= int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;
            int mesAtual = DateTime.Now.Month;

            int idadePessoa= anoAtual - anoNasceu;
            int idadeMeses= idadePessoa *12;
            int idadeDias= idadePessoa * 365;
            int idadeSemana= idadeDias / 7;
            int idadePessoaMenor= idadePessoa - 1;
            int idadeMesesMenor= idadePessoaMenor *12;
            int idadeDiaMenor= idadePessoaMenor *365;
            int idadeSemanaMenor= idadeDiaMenor /7;


            if (mesAtual<mesNasceu){
                Console.WriteLine("A sua idade " + idadePessoaMenor);
                Console.WriteLine("A sua idade em meses é: " + idadeMesesMenor);
                Console.WriteLine("A sua idade em semanas é: " + idadeSemanaMenor);
                Console.WriteLine("A sua idade em dias é: " + idadeDiaMenor);
            }

            else { 
                Console.WriteLine("A sua idade é: " + idadePessoa);
                Console.WriteLine("A sua idade em meses é: " +idadeMeses);
                Console.WriteLine("A sua idade em semanas é: " + idadeSemana);
                Console.WriteLine("A sua idade em dias é: " + idadeDias);
            }
                   
                
            


        }
    }
}
