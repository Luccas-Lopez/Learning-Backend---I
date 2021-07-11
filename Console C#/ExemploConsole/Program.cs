using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Média\n");

            Console.WriteLine("Qual é a primeia nota?");
            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a segunda nota?");
            double segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a terceira nota?");
            double terceiraNota = double.Parse(Console.ReadLine());

            double media = (primeiraNota + segundaNota + terceiraNota) / 3;

            Console.WriteLine("A média das notas foi: " + media.ToString("N1"));

            if (media > 5)
            {
                Console.WriteLine ("Lo studente è passato!!!");
                Console.WriteLine ("O aluno foi Aprovado!!!");
            } else {
                Console.WriteLine ("Lo studente ha falito ;-;");
                Console.WriteLine ("O aluno foi reprovado ;-;");
            }
        }
    }
}
