using System;
using System.Threading;

class Love
{
    static void Main()
    {
        byte[,] pattern1 =
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,},
            {0,0,1,1,1,0,0,0,1,1,1,0,0,},
            {0,1,0,0,0,1,0,1,0,0,0,1,0,},
            {0,1,0,0,0,0,1,0,0,0,0,1,0,},
            {0,1,0,0,0,0,0,0,0,0,0,1,0,},
            {0,0,1,0,0,0,0,0,0,0,1,0,0,},
            {0,0,0,1,0,0,0,0,0,1,0,0,0,},
            {0,0,0,0,1,0,0,0,1,0,0,0,0,},
            {0,0,0,0,0,1,0,1,0,0,0,0,0,},
            {0,0,0,0,0,0,1,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,}
        };
        byte[,] pattern2 =
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,1,1,1,0,0,0,0,0,},
            {0,0,0,1,0,0,1,0,0,1,0,0,0,},
            {0,0,0,0,1,0,1,0,1,0,0,0,0,},
            {0,1,0,0,0,1,1,1,0,0,0,1,0,},
            {0,1,1,1,1,1,1,1,1,1,1,1,0,},
            {0,1,0,0,0,1,1,1,0,0,0,1,0,},
            {0,0,0,0,1,0,1,0,1,0,0,0,0,},
            {0,0,0,1,0,0,1,0,0,1,0,0,0,},
            {0,0,0,0,0,1,1,1,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,}
        };
        string text1 = "Всичко, което правя трябва да бъде за теб.Иначе няма да стане красиво.Всяка моя стъпка трябва към теб да ме води.Иначе няма да смея да тръгна и няма да мога да ходя.И очите ми винаги в твоите трябва да гледат.Иначе ще са слепи за света, в който живея.Всичко, което правя трябва да е на теб посветено.Иначе няма да бъда щастлив,тъй както, когато съм с теб.";
        string text2 = "ВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледаВеселаКоледа";
        char[,] textMatrix1 = new char[((text1.Length / 13) + 1), 13];
        char[,] textMatrix2 = new char[((text2.Length / 13) + 1), 13];
        int indexOfString = -1;
        int firstLineToPrint = -10;
        Console.BufferWidth = Console.WindowWidth = 16;
        Console.BufferHeight = Console.WindowHeight = 11;
        for (int i = 0; i < ((text1.Length / 13) + 1); i++)
        {
            for (int a = 0; a < 13; a++)
            {
                indexOfString++;
                if (indexOfString >= text1.Length)
                {
                    textMatrix1[i, a] = '\u0001';
                }
                else
                {
                    textMatrix1[i, a] = text1[indexOfString];
                }
            }
        }
        indexOfString = -1;
        for (int i = 0; i < ((text2.Length / 13) + 1); i++)
        {
            for (int a = 0; a < 13; a++)
            {
                indexOfString++;
                if (indexOfString >= text2.Length)
                {
                    textMatrix2[i, a] = '\u0001';
                }
                else
                {
                    textMatrix2[i, a] = text2[indexOfString];
                }
            }
        }
        while (firstLineToPrint < ((text1.Length / 13) + 1) - 10)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (firstLineToPrint + i < 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    for (int a = 0; a < 13; a++)
                    {
                        if (pattern1[i, a] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(textMatrix1[firstLineToPrint + i, a]);
                    }
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.Write(textMatrix1[firstLineToPrint + 10, i]);
                Thread.Sleep(120);
            }
            firstLineToPrint++;
        }
        firstLineToPrint = -10;
        while (firstLineToPrint < ((text2.Length / 13) + 1) - 10)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (firstLineToPrint + i < 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    for (int a = 0; a < 13; a++)
                    {
                        if (pattern2[i, a] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write(textMatrix2[firstLineToPrint + i, a]);
                    }
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.Write(textMatrix2[firstLineToPrint + 10, i]);
                Thread.Sleep(80);
            }
            firstLineToPrint++;
        }
        Main();
    }
}
