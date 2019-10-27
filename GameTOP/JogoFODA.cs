using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
        {
            private readonly iJogador _jogadorA;
            private readonly iJogador _jogadorB;

            public JogoFODA(iJogador jogadorA, iJogador jogadorB)
            {
                _jogadorA = jogadorA;
                _jogadorB = jogadorB;
            }
            public void IniciarJogo()
            {
                //Console.WriteLine($"{_jogador._Nome} 1 deu um passe");
                System.Console.WriteLine(_jogadorA.Corre());
                System.Console.WriteLine(_jogadorA.Chuta());
                System.Console.WriteLine(_jogadorA.Passe());
                //
                System.Console.WriteLine("\n PRÓXIMO JOGADOR \n");
                //
                System.Console.WriteLine(_jogadorB.Corre());
                System.Console.WriteLine(_jogadorB.Chuta());
                System.Console.WriteLine(_jogadorB.Passe());
            }

        }
}