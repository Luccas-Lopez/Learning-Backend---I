using System;

namespace exercise_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Com que tipo de Combústivel você deseja abastecer ? (G) para gasolina (A) para Álcool");
            string tipoCombustivel = Console.ReadLine().ToLower();
            Console.WriteLine($"Quantos litros de {tipoCombustivel} você deseja colocar?");
            double litros = double.Parse(Console.ReadLine());

            switch (tipoCombustivel)
            {
                case "a":
                    if (litros <= 20)
                    {
                        double valorFinal = litros * 4.90 * 0.3;
                        Console.WriteLine ("Total a pagar:" + valorFinal + "\n");
                    } else {
                        double valorFinal = litros * 4.90 * 0.5;
                        Console.WriteLine ("Total a pagar:" + valorFinal + "\n");
                    }
                    break;
                case "g":
                    if (litros <= 20)
                    {
                        double valorFinal = litros * 5.30 * 0.4;
                        Console.WriteLine ("Total a pagar:" + valorFinal + "\n");
                    } else {
                        Double valorFinal = litros * 5.30 * 0.6;
                        Console.WriteLine ("Total a pagar:" + valorFinal + "\n");
                    }
                    break;
            }
            
        }
    }
}
