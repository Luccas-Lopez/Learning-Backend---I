﻿using System;

namespace exercise_six
{
    class Program
    {
        static void Main(string[] args)
        {
            
             string[] names = new string[10];

            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite o {i+1}º nome: ");
                names[i] = Console.ReadLine().ToUpper().Trim();
            }

            Console.Write("Digite o nome que deseja buscar: ");
            string busca = Console.ReadLine().ToUpper().Trim();
            bool achei = false;

            foreach (var item in names)
            {
                if (item == busca) {
                    achei = true;
                }
            }
            if (achei) {
                Console.WriteLine($"Achei o nome {busca}");
            }else {
                Console.WriteLine($"Não achei o nome {busca}");
            }
        }
    }
}
