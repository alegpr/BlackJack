namespace Game;

internal class BlackJack
{
    public static int Punteggio(int idx)
    {
        int punteggio = 0;
        
             if (idx == 1 || idx == 14 || idx == 27 || idx == 40)
            punteggio = 1;

        else if (idx == 2 || idx == 15 || idx == 28 || idx == 41)
            punteggio = 2;

        else if (idx == 3 || idx == 16 || idx == 29 || idx == 42)
            punteggio = 3;

        else if (idx == 4 || idx == 17 || idx == 30 || idx == 43)
            punteggio = 4;

        else if (idx == 5 || idx == 18 || idx == 31 || idx == 44)
            punteggio = 5;

        else if (idx == 6 || idx == 19 || idx == 32 || idx == 45)
            punteggio = 6;

        else if (idx == 7 || idx == 20 || idx == 33 || idx == 46)
            punteggio = 7;

        else if (idx == 8 || idx == 21 || idx == 34 || idx == 47)
            punteggio = 8;

        else if (idx == 9 || idx == 22 || idx == 35 || idx == 48)
            punteggio = 9;

        else if (idx == 10 || idx == 23 || idx == 36 || idx == 49)
            punteggio = 10;

        else if (idx == 11 || idx == 24 || idx == 37 || idx == 50)
            punteggio = 10;

        else if (idx == 12 || idx == 25 || idx == 38 || idx == 51)
            punteggio = 10;

        else if (idx == 13 || idx == 26 || idx == 39 || idx == 52)
            punteggio = 10;

        return punteggio;

        // QUESTO METODO E' COMPLETO, NON MODIFICARE NULLA!!!
    }

    public static int ValoreAsso(int Punteggio())
    {
        int val = false;
        if (Punteggio() < 12)
            val
        return val;

        // DA FIXARE
    }
}