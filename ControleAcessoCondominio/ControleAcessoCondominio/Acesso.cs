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
        public static int NumeroAcessos { get => _numeroAcessos; private set => NumeroAcessos = value; }

        private Morador _morador;
        private string _visitantes;
        private TipoAcesso _tipoAcesso;
        public Morador Morador { get => _morador; private set => _morador = value; }
        public string Visitantes { get => _visitantes; private set => _visitantes = value; }
        public TipoAcesso TipoAcesso { get => _tipoAcesso; private set => _tipoAcesso = value; }
        
        public Acesso(Morador morador, string visitantes, TipoAcesso tipoAcesso)
        {
            Morador = morador;
            Visitantes = visitantes;
            TipoAcesso = tipoAcesso;
            if (this.TipoAcesso == TipoAcesso.Permitido) NumeroAcessos++;
        }
    }
}
