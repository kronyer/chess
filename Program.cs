using System;
using tabuleiro;
using xadrez;

namespace Chess_Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine("origem");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] PosicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();


                    Console.Clear() ;
                    Tela.ImprimirTabuleiro(partida.Tab, PosicoesPossiveis);

                    Console.WriteLine("destino");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);

                }

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
