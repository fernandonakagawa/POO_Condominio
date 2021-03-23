using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcessoCondominio
{
    class CondominioConsole
    {
        public static void VerificarAcesso(Condominio c, Morador m)
        {
            Console.WriteLine($"{m.Nome}: {c.VerificarAcesso(m)}");
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
