namespace besenica
{
    using System;

    public class Hangman
    {
        public static void PrintHangman(int count)
        {
            if (count == 1)
            {
                FirstFail();
            }
            else if (count == 2)
            {
                FirstFail();
                SecondFail();
            }
            else if (count == 3)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
            }
            else if (count == 4)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
            }
            else if (count == 5)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
                FifthFail();
            }
            else if (count == 6)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
                FifthFail();
                SixthFail();
            }
            else if (count == 7)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
                FifthFail();
                SixthFail();
                SeventhFail();
            }
            else if (count == 8)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
                FifthFail();
                SixthFail();
                SeventhFail();
                EightFail();
            }
            else if (count == 9)
            {
                FirstFail();
                SecondFail();
                ThirdFail();
                FourthFail();
                FifthFail();
                SixthFail();
                SeventhFail();
                EightFail();
                NinthFail();
            }
        }
        private static void FirstFail()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(50, i);
                Console.WriteLine('*');
            }
        }
        private static void SecondFail()
        {
            Console.SetCursorPosition(50, 0);
            for (int i = 0; i < 10; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        private static void ThirdFail()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(58, i);
                Console.WriteLine('*');
            }
        }
        private static void FourthFail()
        {
            Console.SetCursorPosition(56, 4);
            Console.WriteLine("*****");
            Console.SetCursorPosition(56, 5);
            Console.WriteLine("*   *");
            Console.SetCursorPosition(56, 6);
            Console.WriteLine("*   *");
            Console.SetCursorPosition(56, 7);
            Console.WriteLine("*****");
        }
        private static void FifthFail()
        {
            for (int i = 8; i < 16; i++)
            {
                Console.SetCursorPosition(58, i);
                Console.WriteLine('*');
            }
        }
        private static void SixthFail()
        {
            int x = 55;
            int y = 8;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('*');
                y++;
                x--;
            }
        }
        private static void SeventhFail()
        {
            int x = 61;
            int y = 8;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('*');
                y++;
                x++;
            }
        }
        private static void EightFail()
        {
            int x = 55;
            int y = 16;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('*');
                y++;
                x--;
            }
        }
        private static void NinthFail()
        {
            int x = 61;
            int y = 16;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('*');
                y++;
                x++;
            }
        }
    }
}
