using System;

namespace ControleAcessoCondominio
{
    class Program
    {
        static void Main(string[] args)
        {
            Condominio c = new Condominio("Monte Senai");
            Morador m1 = new Morador("Fulano", "123456", "123456");
            Morador m2 = new Morador("Mariazinha", "234567", "555444");
            c.AdicionarMorador(m1);
            c.AdicionarMorador(m2);
            CondominioConsole.VerificarAcesso(c, m1);
            CondominioConsole.VerificarAcesso(c, m2);
            CondominioConsole.VerificarAcesso(c, m1);
            CondominioConsole.VerificarAcesso(c, m1);
            CondominioConsole.MostrarStatus();
            c.AtivarMorador(m1, false);
            CondominioConsole.VerificarAcesso(c, m1);
            CondominioConsole.MostrarStatus();
            CondominioConsole.ListarMoradores(c);
            c.AdicionarMorador(new Morador("Cleiton","345678", "654321"));
            CondominioConsole.ListarMoradores(c);
            Visitante v1 = new Visitante("Juliana", "987654", m2);
            CondominioConsole.VerificarAcesso(c, v1, m2);
            CondominioConsole.MostrarStatus();

            Pessoa p;
            p = v1;
            p = m2;

            p._nome = "";
        }
    }
}
