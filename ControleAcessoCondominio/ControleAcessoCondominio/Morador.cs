using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Morador
    {
        private string _nome;
        private string _cpf;
        private string _senha;
        private bool _isAtivo;
        private List<Acesso> _acessos;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Senha { get => _senha; private set => _senha = value; }
        public bool IsAtivo { get => _isAtivo; set => _isAtivo = value; }
        public List<Acesso> Acessos { get => _acessos; private set => _acessos = value; }

        public Morador(string nome, string cpf, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
            IsAtivo = true;
            Acessos = new List<Acesso>();
        }

        public bool MudarSenha(string senha)
        {
            if (senha.Length < 6) return false;
            Senha = senha;
            return true;
        }
    }
}
