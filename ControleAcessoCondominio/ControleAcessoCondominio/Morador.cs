using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Morador:Pessoa
    {
        private string _senha;
        private bool _isAtivo;
        
        public string Senha { get => _senha; private set => _senha = value; }
        public bool IsAtivo { get => _isAtivo; set => _isAtivo = value; }
        

        public Morador(string nome, string cpf, string senha):base(nome, cpf)
        {
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
            IsAtivo = true;
        }

        public bool MudarSenha(string senha)
        {
            if (senha.Length < 6) return false;
            Senha = senha;
            return true;
        }
    }
}
