using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Morador:Pessoa
    {
        public const int TAM_MIN_SENHA = 6;
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
            if (senha.Length < TAM_MIN_SENHA) return false;
            Senha = senha;
            return true;
        }
    }
}
