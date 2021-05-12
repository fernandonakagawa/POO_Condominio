using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Pessoa
    {
        protected string _nome;
        private string _cpf;
        private List<Acesso> _acessos;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public List<Acesso> Acessos { get => _acessos; private set => _acessos = value; }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            Acessos = new List<Acesso>();
        }
        public Pessoa(string cpf)
        {
            Nome = "Sem Nome";
            Cpf = cpf;
            Acessos = new List<Acesso>();
        }
    }
}
