using System;
using tabuleiro;
using Xadrez;


namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrex partidaDeXadrex = new ();
                
                while (!partidaDeXadrex.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrex.tabuleiro);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partidaDeXadrex.ExecutaMovimento(origem, destino);
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
