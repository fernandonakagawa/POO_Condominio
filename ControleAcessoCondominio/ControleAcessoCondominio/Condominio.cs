using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Condominio
    {
        private static Condominio _self;
        private static int _numeroMoradoresAtivos = 0;
        public static Condominio Self { get => _self; set => _self = value; }
        public static int NumeroMoradoresAtivos { get => _numeroMoradoresAtivos;
            private set => _numeroMoradoresAtivos = value; }


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

        public TipoAcesso VerificarAcesso(Pessoa p, Morador m = null)
        {
            if (p is Visitante)
            {
                if (Moradores.IndexOf(m) == -1) return TipoAcesso.Negado;
                if (!m.IsAtivo) return TipoAcesso.Desativado;
                if (((Visitante)p).Anfitrioes.IndexOf(m) == -1) {
                    ((Visitante)p).AdicionarAnfitriao(m);
                }
            }
            else if (p is Morador) {
                if (Moradores.IndexOf((Morador)p) == -1) return TipoAcesso.Negado;
                if (!((Morador)p).IsAtivo) return TipoAcesso.Desativado;
            }
            Acesso a = new Acesso(p, TipoAcesso.Permitido);
            Acessos.Add(a);
            p.Acessos.Add(a);
            return TipoAcesso.Permitido;
        }

        public bool AdicionarMorador(Morador m)
        {
            if (Moradores.IndexOf(m) == -1)
            {
                this.Moradores.Add(m);
                if (m.IsAtivo) NumeroMoradoresAtivos++;
                return true;
            }
            return false;
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
