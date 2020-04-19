using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Primeiro Prgrama - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
