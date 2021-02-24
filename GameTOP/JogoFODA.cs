using System;
using GameTOP.Interface;

namespace GameTOP
{
    class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Chuta());
            Console.Write(_jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n \n");    
            //
            Console.Write(_jogadorB.Corre());
            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Passe());
        }
    }
}