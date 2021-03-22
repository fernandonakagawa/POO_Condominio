using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Condominio
    {
        private static int _numeroMoradoresAtivos;
        public static int NumeroMoradoresAtivos { get => _numeroMoradoresAtivos; 
            set => _numeroMoradoresAtivos = value; }
        
        private string _nome;
        private List<Morador> _moradores;
        private List<Acesso> _acessos;
        public string Nome { get => _nome; private set => _nome = value; }
        public List<Morador> Moradores { get => _moradores; private set => _moradores = value; }
        public List<Acesso> Acessos { get => _acessos; private set => _acessos = value; }
        

        public Condominio(string nome)
        {
            Nome = nome;
            this.Moradores = new List<Morador>();
            this.Acessos = new List<Acesso>();
        }

        public TipoAcesso VerificarAcesso(Morador m)
        {
            if (Moradores.IndexOf(m) == -1) return TipoAcesso.Negado;
            if (!m.IsAtivo) return TipoAcesso.Desativado;
            return TipoAcesso.Permitido;
        }

        public void AdicionarMorador(Morador m)
        {
            Moradores.Add(m);
            if (m.IsAtivo) NumeroMoradoresAtivos++;
        }
        public bool AtivarMorador(Morador m, bool ativar)
        {
            if (Moradores.IndexOf(m) == -1) return false;

            if (!m.IsAtivo && ativar) NumeroMoradoresAtivos++;
            else if (m.IsAtivo && !ativar) NumeroMoradoresAtivos--;
            m.IsAtivo = ativar;

            return true;
        }
    }
}
