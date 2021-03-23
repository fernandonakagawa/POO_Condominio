using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class CondominioConsole
    {
        public static void VerificarAcesso(Condominio c, Pessoa p, Morador m = null)
        {
            Console.WriteLine($"{p.Nome}: {c.VerificarAcesso(p, m)}");
        }
        public static void MostrarStatus()
        {
            Console.WriteLine($"Condomínio: moradores ativos = {Condominio.NumeroMoradoresAtivos}" +
                $" Acessos = {Acesso.NumeroAcessos}");
        }
        public static void ListarMoradores(Condominio c)
        {
            Console.WriteLine("=====Lista de Moradores=====");
            foreach(Morador m in c.Moradores)
            {
                Console.WriteLine($"{m.Nome} {m.Cpf}");
            }
            Console.WriteLine();
        }
    }
}
