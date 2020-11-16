using System;

namespace Conversor_de_idade_semanas
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Em que ano estamos? ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Em que ano você nasceu? ");
            int anoNasc = int.Parse(Console.ReadLine());

            int sub = (anoAtual - anoNasc);
            //Console.Write("Você tem: "+sub+" anos de idade");

            int sem = sub * 53;
            Console.Write("Você tem: "+sem+" semanas de idade");

            
        }
    }
}
