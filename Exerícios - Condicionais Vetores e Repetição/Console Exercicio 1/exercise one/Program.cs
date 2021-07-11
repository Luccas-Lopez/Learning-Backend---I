using System;

namespace exercise_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int anoDeNascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idadePessoa = anoAtual - anoDeNascimento;

            if (idadePessoa <18){
                Console.WriteLine (" Você ainda não é apto para votar este ano!");

            }else {
                Console.WriteLine("Você tem: " + idadePessoa + " anos, portanto está apto para votar este ano!" +"\n");
            }


            
        }
    }
}
