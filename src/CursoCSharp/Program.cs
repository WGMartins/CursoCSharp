﻿using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                // Fundamentos
                {"Primeiro Prgrama - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else  - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If  - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch  - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While  - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While  - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For  - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach  - Estruturas de Controle", EstruturaForeach.Executar },
                {"Usando Break  - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue  - Estruturas de Controle", UsandoContinue.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
