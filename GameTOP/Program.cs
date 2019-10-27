using System;
using GameTop.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {            
            var jogo = new JogoFODA(
                new Jogador1("Alisson"),
                new Jogador3()
              //  new Jogador3()
                );
            jogo.IniciarJogo();
        }        
    }    
}
