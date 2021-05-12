using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class Visitante:Pessoa
    {
        private List<Morador> _anfitrioes;
        public List<Morador> Anfitrioes { get => _anfitrioes; private set => _anfitrioes = value; }
        
        public Visitante(string nome, string cpf, Morador anfitriao):base(nome, cpf)
        {
            Anfitrioes = new List<Morador>();
            Anfitrioes.Add(anfitriao);
            //this._nome = " ";
        }
        public Visitante(string nome, Morador anfitriao) : base(nome, "")
        {
            Anfitrioes = new List<Morador>();
            Anfitrioes.Add(anfitriao);
            //this._nome = " ";
        }
        public void AdicionarAnfitriao(Morador m)
        {
            Anfitrioes.Add(m);
        }

        
    }
}
