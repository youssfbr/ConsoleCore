using System;
using GameTOP.Interface;

namespace GameTop.Lib
{
public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }

        //Corre
        public string Corre()
        {
            return $"{_Nome} está correndo";
        }

        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando";
        }
    }
}