using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Visitante
    {
        private string _nome;
        private string _cpf;
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }

        public Visitante(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
