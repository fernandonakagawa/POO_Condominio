using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    enum TipoAcesso
    {
        Negado, Permitido, Desativado,
    }
    class Acesso
    {
        private static int _numeroAcessos = 0;
        public static int NumeroAcessos { get => _numeroAcessos; private set => _numeroAcessos = value; }

        private Pessoa _pessoa;

        private TipoAcesso _tipoAcesso;
        public Pessoa Pessoa { get => _pessoa; private set => _pessoa = value; }
        public TipoAcesso TipoAcesso { get => _tipoAcesso; private set => _tipoAcesso = value; }
        
        public Acesso(Pessoa pessoa, TipoAcesso tipoAcesso)
        {
            Pessoa = pessoa;
            TipoAcesso = tipoAcesso;
            if (this.TipoAcesso == TipoAcesso.Permitido) NumeroAcessos++;
        }
        public Acesso(Condominio c, string cpf, TipoAcesso tipoAcesso)
        {
            //... fazer toda a implementação
        }
    }
}
