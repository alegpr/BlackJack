using Lib;
using Game;
namespace MainFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rnd = new Random();

            int idx;
            int punteggio = 0;
            RandCarta(out idx);

            BlackJack.Punteggio(idx);

            Carte.Disegnacarte(idx);
        }

        public static void RandCarta(out int idx)
        {
            Random rnd = new Random();
            idx = rnd.Next(1, 53);
        }

        
    }

}
