using System;
using tabuleiro;
using Xadrez;


namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicaoXadrez = new('c', 7);
            Console.WriteLine(posicaoXadrez);


            Console.WriteLine(posicaoXadrez.ToPosicao());
        }
    }
}
