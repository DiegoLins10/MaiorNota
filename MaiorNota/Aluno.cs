using System;
using System.Collections.Generic;
using System.Text;

namespace MaiorNota
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }

        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }
    }
}
