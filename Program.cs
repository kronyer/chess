﻿using System;
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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.WriteLine("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoOrigem(origem);

                        bool[,] PosicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();


                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, PosicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);

                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

