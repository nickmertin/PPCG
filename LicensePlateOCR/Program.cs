using System;
using System.Drawing;

class _
{
    static Bitmap bmp;
    static bool b(int x, int y) => bmp.GetPixel(x, y).GetBrightness() < .4;
    static char l(int x, int y)
    {
        if (y < 45)
            return b(x + 5, 145) ? ((b(x + 30, 100) || b(x + 30, 50)) ? (b(x + 68, 94) ? (b(x + 40, 50) ? 'D' : b(x + 40, 120) ? (b(x + 45, 80) ? 'M' : 'N') : 'H') : b(x, 97) ? (b(x + 30, 140) ? 'E' : b(x + 60, 70) ? (b(x + 50, 140) ? 'R' : 'P') : 'F') : b(x + 65, 45) ? (b(x + 5, 100) ? 'K' : b(x + 30, 145) ? 'Z' : 'X') : 'B') : b(x + 30, 140) ? 'L' : '1') : b(x + 30, 55) ? (b(x + 60, 70) ? '7' : 'T') : b(x + 2, 100) ? 'U' : b(x + 30, 70) ? 'W' : b(x + 15, 100) ? 'V' : 'Y';
        if (y < 70)
            return b(x + 50, 110) ? (b(x + 50, 70) ? (b(x + 10, 110) ? (b(x + 30, 100) ? (b(x + 55, 80) ? '8' : '6') : b(x + 55, 80) ? '0' : 'G') : b(x + 10, 70) ? (b(x + 60, 80) ? '9' : 'S') : b(x + 60, 120) ? '3' : '2') : 'G') : b(x + 30, 125) ? 'Q' : 'C';
        if (y > 150)
            return 'A';
        if (y > 120)
            return 'J';
        if (y > 95)
            return b(x + 10, 135) ? '5' : '4';
        return '-';
    }
    static void Main(string[] args)
    {
        bmp = new Bitmap(Console.ReadLine());
        bool state = true;
        int space = int.MinValue;
        for (int x = 100; x < 800; ++x)
        {
            for (int y = 40; y < 160; ++y)
                if (state)
                {
                    if (b(x, y))
                    {
                        if (space > 50)
                            Console.Write(' ');
                        Console.Write(l(x, y));
                        state = false;
                        goto bad;
                    }
                }
                else if (b(x, y))
                    goto bad;
            if (!state)
            {
                state = true;
                space = 0;
            }
            else
                ++space;
            bad:
            continue;
        }
    }
}
