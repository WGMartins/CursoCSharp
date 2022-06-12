using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento ()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var novoCliene = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliene.Nome);
            Console.WriteLine(novoCliene.GetDataNascimento());
        }
    }
}
