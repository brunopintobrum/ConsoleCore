using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;
        public Jogador2(string nome)
        {
            _Nome =nome;
        }

        public string Chuta()
        {
            return $"{_Nome} estas Pateando \n";
        }

        public string Corre()
        {
            return $"{_Nome} estas Corriendo \n";
        }

        public string Passe()
        {
            return $"{_Nome} estas Pasando \n \n";
        }
    }
}