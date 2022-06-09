using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // acesse a variável 'a' dentro do método Executar

            DesafioAtributo desafioAtributo = new DesafioAtributo();
            Console.WriteLine(desafioAtributo.a);
        }
    }
}
