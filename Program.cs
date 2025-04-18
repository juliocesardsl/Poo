using System;
using System.Collections.Generic;


namespace Poo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Alunos> List = new List<Alunos>();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a idade do aluno: ");
                string idade = Console.ReadLine();

                Alunos aluno = new Alunos(nome, idade);

                List.Add(aluno);
            }
            foreach (var aluno in List)
            {
                aluno.Maior_Menor();

            }
            Console.WriteLine("Os outros alunos não eram maiores de idades");
        }
    }
    public class Alunos
    {
        private string name;
        private string old;

        
        public Alunos(string name, string old)
        {
            this.name = name;
            this.old = old;
        }

        public void Maior_Menor()
        {
            if (int.TryParse(old, out int idade))
            {
                if (int.Parse(old) >= 18)
                {
                    Console.WriteLine($"O aluno {name} é maior de idade!");
                }
                else
                {
                    Console.WriteLine($"O aluno {name} é menor de idade!");
                }
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
        }
    }
}