using System;
using System.Collections.Generic;

namespace MaiorNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de alunos");

            int quant = Convert.ToInt32(Console.ReadLine());
            Aluno[] alunos = new Aluno[quant];


            Console.WriteLine("Nome do aluno(ENTER) Sua nota");

            for (int valorX = 0; valorX < alunos.Length; valorX++)
            {
                Console.WriteLine("Aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("nota: ");
                int nota = int.Parse(Console.ReadLine());
                Aluno aluno = new Aluno(nome, nota);
                alunos[valorX] = aluno;
            }

            int maiorNota = 0;
            string NomeMaiorNota = "";
            foreach (var i in alunos)
            {
                if (i.Nota > maiorNota)
                {
                    maiorNota = i.Nota;
                    NomeMaiorNota = i.Nome;
                }
            }

            Console.WriteLine("A maior nota foi " + maiorNota);

        }
    }
}