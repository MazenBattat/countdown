using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    class Program
    {
        static int pi, pj, position1, position2;
        static int life = 5;
        static int gameScore = 0;

        static string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string[] numbersDecreasing = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string[] listUnTouch = { "#", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        static void Main()
        {
            Console.CursorVisible = false;
            Random random = new Random();
            ConsoleKeyInfo cki;
            string[,] a = new string[23, 53];
            int i, j;
            int counter = 0;
            gameBeginner();
            DateTime startTime = DateTime.Now;
            DateTime lastCountdownActionTime = DateTime.Now;
            DateTime lastSifirlarinHareketiTime = DateTime.Now;


            // GENERATION OF OUTER WALLS 

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 53; j++)
                {
                    if (i == 0)
                    {
                        if (j >= 0 && j < 52)
                        {
                            a[i, j] = "#";
                            Console.Write(a[i, j]);
                        }
                        else if (j == 52)
                        {
                            a[i, j] = "#";
                            Console.WriteLine(a[i, j]);
                        }
                    }
                    else if (0 < i && i < 22)
                    {
                        if (j == 0)
                        {
                            a[i, j] = "#";
                            Console.Write(a[i, j]);
                        }
                        else if (j > 0 && j < 52)
                        {
                            a[i, j] = " ";
                            Console.Write(a[i, j]);
                        }
                        else if (j == 52)
                        {
                            a[i, j] = "#";
                            Console.WriteLine(a[i, j]);
                        }
                    }
                    else if (i == 22)
                    {
                        if (j >= 0 && j < 52)
                        {
                            a[i, j] = "#";
                            Console.Write(a[i, j]);
                        }
                        else if (j == 52)
                        {
                            a[i, j] = "#";
                            Console.WriteLine(a[i, j]);
                        }
                    }
                }
            }

            Console.SetCursorPosition(55, 3);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("   Time  :  "); Console.ResetColor();
            Console.SetCursorPosition(55, 5);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("   Life  :  "); Console.ResetColor();
            Console.SetCursorPosition(67, 5);
            Console.WriteLine(life);
            Console.SetCursorPosition(55, 7);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("   Score :  "); Console.ResetColor();
            Console.SetCursorPosition(67, 7);
            Console.WriteLine(gameScore);


            // RANDOM GENERATION OF INNER WALLS

            int wj, wi;
            int count11w = 1;
            while (count11w <= 3)
            {
                Random randomwj = new Random();
                wj = randomwj.Next(1, 52);
                Random randomwi = new Random();
                wi = randomwi.Next(1, 22);
                Random randomw = new Random();
                int w11L = randomw.Next(1, 3);
                if (w11L == 1)//length 11 vertically
                {
                    if (a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj + 1] != "#" && a[wi - 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi + 1, wj - 1] != "#" && a[wi + 2, wj] != "#")
                        {
                            if (a[wi + 2, wj + 1] != "#" && a[wi + 2, wj - 1] != "#" && a[wi + 3, wj] != "#")
                            {
                                if (a[wi + 3, wj + 1] != "#" && a[wi + 3, wj - 1] != "#" && a[wi + 4, wj] != "#")
                                {
                                    if (a[wi + 4, wj + 1] != "#" && a[wi + 4, wj - 1] != "#" && a[wi + 5, wj] != "#")
                                    {
                                        if (a[wi + 5, wj + 1] != "#" && a[wi + 5, wj - 1] != "#" && a[wi + 6, wj] != "#")
                                        {
                                            if (a[wi + 6, wj + 1] != "#" && a[wi + 6, wj - 1] != "#" && a[wi + 7, wj] != "#")
                                            {
                                                if (a[wi + 7, wj + 1] != "#" && a[wi + 7, wj - 1] != "#" && a[wi + 8, wj] != "#")
                                                {
                                                    if (a[wi + 8, wj + 1] != "#" && a[wi + 8, wj - 1] != "#" && a[wi + 9, wj] != "#")
                                                    {
                                                        if (a[wi + 9, wj + 1] != "#" && a[wi + 9, wj - 1] != "#" && a[wi + 10, wj] != "#")
                                                        {
                                                            if (a[wi + 10, wj + 1] != "#" && a[wi + 10, wj - 1] != "#" && a[wi + 11, wj] != "#" && a[wi + 11, wj + 1] != "#" && a[wi + 11, wj - 1] != "#")
                                                            {
                                                                a[wi, wj] = "#"; a[wi + 1, wj] = "#"; a[wi + 2, wj] = "#"; a[wi + 3, wj] = "#"; a[wi + 4, wj] = "#"; a[wi + 5, wj] = "#";
                                                                a[wi + 6, wj] = "#"; a[wi + 7, wj] = "#"; a[wi + 8, wj] = "#"; a[wi + 9, wj] = "#"; a[wi + 10, wj] = "#";
                                                                for (int w11 = 0; w11 < 11; w11++)
                                                                {
                                                                    Console.SetCursorPosition(wj, wi);
                                                                    Console.Write("#");
                                                                    wi++;
                                                                }
                                                                count11w = count11w + 1;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                else//length 11 horizontally
                {
                    if (a[wi, wj] != "#" && a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj - 1] != "#" && a[wi + 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi - 1, wj + 1] != "#" && a[wi, wj + 2] != "#")
                        {
                            if (a[wi + 1, wj + 2] != "#" && a[wi - 1, wj + 2] != "#" && a[wi, wj + 3] != "#")
                            {
                                if (a[wi + 1, wj + 3] != "#" && a[wi - 1, wj + 3] != "#" && a[wi, wj + 4] != "#")
                                {
                                    if (a[wi + 1, wj + 4] != "#" && a[wi - 1, wj + 4] != "#" && a[wi, wj + 5] != "#")
                                    {
                                        if (a[wi + 1, wj + 5] != "#" && a[wi - 1, wj + 5] != "#" && a[wi, wj + 6] != "#")
                                        {
                                            if (a[wi + 1, wj + 6] != "#" && a[wi - 1, wj + 6] != "#" && a[wi, wj + 7] != "#")
                                            {
                                                if (a[wi + 1, wj + 7] != "#" && a[wi - 1, wj + 7] != "#" && a[wi, wj + 8] != "#")
                                                {
                                                    if (a[wi + 1, wj + 8] != "#" && a[wi - 1, wj + 8] != "#" && a[wi, wj + 9] != "#")
                                                    {
                                                        if (a[wi + 1, wj + 9] != "#" && a[wi - 1, wj + 9] != "#" && a[wi, wj + 10] != "#")
                                                        {
                                                            if (a[wi + 1, wj + 10] != "#" && a[wi - 1, wj + 10] != "#" && a[wi, wj + 11] != "#" && a[wi + 1, wj + 11] != "#" && a[wi - 1, wj + 11] != "#")
                                                            {
                                                                a[wi, wj] = "#"; a[wi, wj + 1] = "#"; a[wi, wj + 2] = "#"; a[wi, wj + 3] = "#"; a[wi, wj + 4] = "#"; a[wi, wj + 5] = "#"; a[wi, wj + 6] = "#"; a[wi, wj + 7] = "#"; a[wi, wj + 8] = "#"; a[wi, wj + 9] = "#"; a[wi, wj + 10] = "#";
                                                                for (int w11 = 0; w11 < 11; w11++)
                                                                {
                                                                    Console.SetCursorPosition(wj, wi);
                                                                    Console.Write("#");
                                                                    wj++;
                                                                }
                                                                count11w = count11w + 1;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            int count7w = 1;
            while (count7w <= 5)
            {
                Random randomwj = new Random();
                wj = randomwj.Next(1, 52);
                Random randomwi = new Random();
                wi = randomwi.Next(1, 22);
                Random randomw = new Random();
                int w7L = randomw.Next(1, 3);
                if (w7L == 1)//length 7 horizontally
                {
                    if (a[wi, wj] != "#" && a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj - 1] != "#" && a[wi + 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi - 1, wj + 1] != "#" && a[wi, wj + 2] != "#")
                        {
                            if (a[wi + 1, wj + 2] != "#" && a[wi - 1, wj + 2] != "#" && a[wi, wj + 3] != "#")
                            {
                                if (a[wi + 1, wj + 3] != "#" && a[wi - 1, wj + 3] != "#" && a[wi, wj + 4] != "#")
                                {
                                    if (a[wi + 1, wj + 4] != "#" && a[wi - 1, wj + 4] != "#" && a[wi, wj + 5] != "#")
                                    {
                                        if (a[wi + 1, wj + 5] != "#" && a[wi - 1, wj + 5] != "#" && a[wi, wj + 6] != "#")
                                        {
                                            if (a[wi + 1, wj + 6] != "#" && a[wi - 1, wj + 6] != "#" && a[wi, wj + 7] != "#" && a[wi + 1, wj + 7] != "#" && a[wi - 1, wj + 7] != "#")
                                            {

                                                a[wi, wj] = "#"; a[wi, wj + 1] = "#"; a[wi, wj + 2] = "#"; a[wi, wj + 3] = "#"; a[wi, wj + 4] = "#"; a[wi, wj + 5] = "#"; a[wi, wj + 6] = "#";
                                                for (int w7 = 0; w7 < 7; w7++)
                                                {

                                                    Console.SetCursorPosition(wj, wi);
                                                    Console.Write("#");
                                                    wj++;
                                                }
                                                count7w = count7w + 1;

                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                else //length 7 vertically
                {
                    if (a[wi, wj] != "#" && a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj + 1] != "#" && a[wi - 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi + 1, wj - 1] != "#" && a[wi + 2, wj] != "#")
                        {
                            if (a[wi + 2, wj + 1] != "#" && a[wi + 2, wj - 1] != "#" && a[wi + 3, wj] != "#")
                            {
                                if (a[wi + 3, wj + 1] != "#" && a[wi + 3, wj - 1] != "#" && a[wi + 4, wj] != "#")
                                {
                                    if (a[wi + 4, wj + 1] != "#" && a[wi + 4, wj - 1] != "#" && a[wi + 5, wj] != "#")
                                    {
                                        if (a[wi + 5, wj + 1] != "#" && a[wi + 5, wj - 1] != "#" && a[wi + 6, wj] != "#")
                                        {
                                            if (a[wi + 6, wj + 1] != "#" && a[wi + 6, wj - 1] != "#" && a[wi + 7, wj] != "#" && a[wi + 7, wj + 1] != "#" && a[wi + 7, wj - 1] != "#")
                                            {
                                                a[wi, wj] = "#"; a[wi + 1, wj] = "#"; a[wi + 2, wj] = "#"; a[wi + 3, wj] = "#"; a[wi + 4, wj] = "#"; a[wi + 5, wj] = "#"; a[wi + 6, wj] = "#";
                                                for (int w7 = 0; w7 < 7; w7++)
                                                {
                                                    Console.SetCursorPosition(wj, wi);
                                                    Console.Write("#");
                                                    wi++;
                                                }
                                                count7w = count7w + 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            int count3w = 1;
            while (count3w <= 20)
            {
                Random randomwj = new Random();
                wj = randomwj.Next(1, 52);
                Random randomwi = new Random();
                wi = randomwi.Next(1, 22);
                Random randomw = new Random();
                int w3L = randomw.Next(1, 3);
                if (w3L == 1)//length 3 vertically
                {
                    if (a[wi, wj] != "#" && a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj + 1] != "#" && a[wi - 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi + 1, wj - 1] != "#" && a[wi + 2, wj] != "#")
                        {
                            if (a[wi + 2, wj + 1] != "#" && a[wi + 2, wj - 1] != "#" && a[wi + 3, wj] != "#" && a[wi + 3, wj + 1] != "#" && a[wi + 3, wj - 1] != "#")
                            {
                                a[wi, wj] = "#"; a[wi + 1, wj] = "#"; a[wi + 2, wj] = "#";
                                for (int w3 = 0; w3 < 3; w3++)
                                {
                                    Console.SetCursorPosition(wj, wi);
                                    Console.Write("#");
                                    wi++;
                                }
                                count3w = count3w + 1;
                            }
                        }
                    }
                }
                else if (w3L == 2)//length 3 horizontally
                {
                    if (a[wi, wj] != "#" && a[wi, wj + 1] != "#" && a[wi, wj - 1] != "#" && a[wi + 1, wj] != "#" && a[wi - 1, wj] != "#" && a[wi - 1, wj - 1] != "#" && a[wi + 1, wj - 1] != "#")
                    {
                        if (a[wi + 1, wj + 1] != "#" && a[wi - 1, wj + 1] != "#" && a[wi, wj + 2] != "#")
                        {
                            if (a[wi + 1, wj + 2] != "#" && a[wi - 1, wj + 2] != "#" && a[wi, wj + 3] != "#" && a[wi - 1, wj + 3] != "#" && a[wi + 1, wj + 3] != "#")
                            {
                                a[wi, wj] = "#"; a[wi, wj + 1] = "#"; a[wi, wj + 2] = "#";
                                for (int w3 = 0; w3 < 3; w3++)
                                {
                                    Console.SetCursorPosition(wj, wi);
                                    Console.Write("#");
                                    wj++;
                                }
                                count3w = count3w + 1;
                            }
                        }
                    }
                }
            }


            //  RANDOM GENERATION OF 70 NUMBERS (0-9)

            while (counter < 71)
            {
                int number = random.Next(0, 10);
                position1 = random.Next(1, 52);
                position2 = random.Next(1, 22);
                if (a[position2, position1] == " ")
                {
                    counter++;
                    if (number == 0)
                    {
                        // Set the console foreground color to red for "0"
                        Console.SetCursorPosition(position1, position2);
                        a[position2, position1] = Convert.ToString(number);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine(a[position2, position1]); Console.ResetColor();

                    }
                    else
                    {
                        // Set the console foreground color to green for other numbers
                        Console.SetCursorPosition(position1, position2);
                        a[position2, position1] = Convert.ToString(number);
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(a[position2, position1]); Console.ResetColor();
                    }
                }
            }

            // RANDOM GENERATION OF PLAYER (P)

            do
            {
                Random randomj = new Random();
                pj = randomj.Next(1, 52);
                Random randomi = new Random();
                pi = randomi.Next(1, 22);
            }
            while (a[pi, pj] != " ");
            Console.SetCursorPosition(pj, pi);
            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
            a[pi, pj] = "P";

            while (true)
            {
                if (life == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("       Game Over...");
                    Console.ResetColor();
                    Console.WriteLine("       Your Score: " + gameScore + "     ");
                    Console.ResetColor(); Console.ReadKey();
                }

                // CountdownAction fonksiyonunu 15 saniyede bir çağır
                if ((DateTime.Now - lastCountdownActionTime).TotalMilliseconds >= 15000)
                {
                    CountdownAction(a);
                    lastCountdownActionTime = DateTime.Now;
                }

                // SifirlarinHareketi fonksiyonunu 1 saniyede bir çağır
                if ((DateTime.Now - lastSifirlarinHareketiTime).TotalMilliseconds >= 1000)
                {
                    SifirlarinHareketi(a);
                    lastSifirlarinHareketiTime = DateTime.Now;
                }

                bool push = false; ;
                int counterp = 1;
                int temp = 0;
                bool smash = false;
                int number = 0;

                // PLAYER (P) MOVEMENTS - PUSHING - SMASHING - SCORING

                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);       // true: do not write character 
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (cki.Key == ConsoleKey.RightArrow && pj < 51)
                    {
                        string currentCellValue = a[pi, pj + 1];
                        // Eğer currentCellValue listNumber içinde yoksa işlemi yap, duvar yoksa hareket et
                        if (!listUnTouch.Contains(currentCellValue))
                        {
                            Console.SetCursorPosition(pj, pi);
                            Console.WriteLine(" ");
                            a[pi, pj] = " ";
                            pj++;
                            a[pi, pj] = "P";
                            Console.SetCursorPosition(pj, pi);
                            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        }
                        //sayı itmesi
                        else if (numbers.Contains(currentCellValue))
                        {
                            while (a[pi, pj + counterp] != " " && a[pi, pj + counterp] != "#")
                            {
                                counterp++;
                            }
                            //bir sayı varsa sağ itilebilir
                            if (counterp == 2) push = true;

                            // Duvar kontrolü eklenmiş olan for döngüsü
                            for (int n = counterp - 1; n > 1; n--)
                            {
                                //iki iki kontrol ederek sondan azalan veya eşitse itilebilir
                                if (int.TryParse(a[pi, pj + n], out temp) &&
                                    int.Parse(a[pi, pj + n]) <= int.Parse(a[pi, pj + n - 1]))
                                {
                                    push = true;
                                }
                                //diğer durumlarda itilemez ve break atar.
                                else
                                {
                                    push = false;
                                    break;
                                }
                            }

                            //smash kontrolü
                            if (counterp == 2) smash = false;
                            else if (counterp > 2) smash = true;

                            //dizinin sağı boşsa ve azalansa
                            if (a[pi, pj + counterp] == " " && push)
                            {
                                // Sondan başlayarak tüm sayıları sağa kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi, pj + n - 1], out temp))
                                    {
                                        a[pi, pj + n - 1] = " ";
                                        a[pi, pj + n] = temp.ToString();
                                        Console.SetCursorPosition(pj + n - 1, pi);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj + n, pi);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();

                                    }
                                }

                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pj++;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }

                            //sayının sağı duvarsa, azalansa ve smash edilebilirse
                            else if (a[pi, pj + counterp] == "#" && smash && push)
                            {
                                //puan kontrolü
                                if (a[pi, pj + counterp - 1] == "0")
                                {
                                    gameScore += 20;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi, pj + counterp - 1] == "1" || a[pi, pj + counterp - 1] == "2" || a[pi, pj + counterp - 1] == "3" || a[pi, pj + counterp - 1] == "4")
                                {
                                    gameScore += 2;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi, pj + counterp - 1] == "5" || a[pi, pj + counterp - 1] == "6" || a[pi, pj + counterp - 1] == "7" || a[pi, pj + counterp - 1] == "8" || a[pi, pj + counterp - 1] == "9")
                                {
                                    gameScore += 1;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }

                                // Her smash edilen sayı için rastgele sayı oluştur

                                do
                                {
                                    position1 = random.Next(1, 52);
                                    position2 = random.Next(1, 22);
                                    number = random.Next(5, 10);

                                } while (a[position2, position1] != " ");
                                a[position2, position1] = number.ToString();
                                Console.SetCursorPosition(position1, position2);
                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(number); Console.ResetColor();


                                // Sondan başlayarak tüm sayıları sağa kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi, pj + n - 2], out temp))
                                    {
                                        a[pi, pj + n - 2] = " ";
                                        a[pi, pj + n - 1] = temp.ToString();
                                        Console.SetCursorPosition(pj + n - 2, pi);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj + n - 1, pi);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.Write(temp); Console.ResetColor();
                                    }
                                }

                                //Playeri hareket ettirme
                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pj++;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }
                        }
                    }

                    if (cki.Key == ConsoleKey.LeftArrow && pj > 1)
                    {
                        string currentCellValue = a[pi, pj - 1];

                        // Eğer currentCellValue listNumber içinde yoksa işlemi yap, duvar yoksa hareket etmeyi sağlıyor
                        if (!listUnTouch.Contains(currentCellValue))
                        {
                            Console.SetCursorPosition(pj, pi);
                            Console.WriteLine(" ");
                            a[pi, pj] = " ";
                            pj--;
                            a[pi, pj] = "P";
                            Console.SetCursorPosition(pj, pi);
                            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        }

                        //sayı itmesi
                        else if (numbers.Contains(currentCellValue))
                        {
                            //Player dahil kaç tane sayı olduğunu sayıyor
                            while (a[pi, pj - counterp] != " " && a[pi, pj - counterp] != "#")
                            {
                                counterp++;
                            }
                            //bir sayı varsa sola itilebilir
                            if (counterp == 2) push = true;
                            // Duvar kontrolü eklenmiş olan for döngüsü
                            for (int n = counterp - 1; n > 1; n--)
                            {
                                //iki iki kontrol ederek sondan azalan veya eşitse itilebilir
                                if (int.TryParse(a[pi, pj - n], out temp) &&
                                    int.Parse(a[pi, pj - n]) <= int.Parse(a[pi, pj - n + 1]))
                                {
                                    push = true;
                                }
                                //diğer durumlarda itilemez ve break atar.
                                else
                                {
                                    push = false;
                                    break;
                                }
                            }
                            //smash kontrolü
                            if (counterp == 2) smash = false;
                            else if (counterp > 2) smash = true;

                            //dizinin sola boşsa ve azalansa
                            if (a[pi, pj - counterp] == " " && push)
                            {
                                // Sondan başlayarak tüm sayıları sola kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi, pj - n + 1], out temp))
                                    {
                                        a[pi, pj - n + 1] = " ";
                                        a[pi, pj - n] = temp.ToString();
                                        Console.SetCursorPosition(pj - n + 1, pi);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj - n, pi);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }
                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pj--;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }

                            //sayının solu duvarsa, azalansa ve smash edilebilirse
                            else if (a[pi, pj - counterp] == "#" && smash && push)
                            {
                                //puan kontrolü
                                if (a[pi, pj - counterp + 1] == "0")
                                {
                                    gameScore += 20;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi, pj - counterp + 1] == "1" || a[pi, pj - counterp + 1] == "2" || a[pi, pj - counterp + 1] == "3" || a[pi, pj - counterp + 1] == "4")
                                {
                                    gameScore += 2;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi, pj - counterp + 1] == "5" || a[pi, pj - counterp + 1] == "6" || a[pi, pj - counterp + 1] == "7" || a[pi, pj - counterp + 1] == "8" || a[pi, pj - counterp + 1] == "9")
                                {
                                    gameScore += 1;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }

                                //her smash edilen sayı için rastgele sayının oluşması
                                do
                                {
                                    position1 = random.Next(1, 52);
                                    position2 = random.Next(1, 22);
                                    number = random.Next(5, 10);

                                } while (a[position2, position1] != " ");
                                a[position2, position1] = number.ToString();
                                Console.SetCursorPosition(position1, position2);
                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(number); Console.ResetColor();

                                // Sondan başlayarak tüm sayıları sola kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi, pj - n + 2], out temp))
                                    {
                                        a[pi, pj - n + 2] = " ";
                                        a[pi, pj - n + 1] = temp.ToString();
                                        Console.SetCursorPosition(pj - n + 2, pi);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj - n + 1, pi);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }

                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pj--;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }
                        }
                    }
                    if (cki.Key == ConsoleKey.UpArrow && pi > 1)
                    {
                        //Player'in üstündeki değeri alıyor
                        string currentCellValue = a[pi - 1, pj];

                        // Eğer currentCellValue listNumber içinde yoksa işlemi yap, duvar yoksa hareket etmeyi sağlıyor
                        if (!listUnTouch.Contains(currentCellValue))
                        {
                            Console.SetCursorPosition(pj, pi);
                            Console.WriteLine(" ");
                            a[pi, pj] = " ";
                            pi--;
                            a[pi, pj] = "P";
                            Console.SetCursorPosition(pj, pi);
                            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        }

                        //sayı itmesi
                        else if (numbers.Contains(currentCellValue))
                        {
                            while (a[pi - counterp, pj] != " " && a[pi - counterp, pj] != "#")
                            {
                                counterp++;
                            }
                            //bir sayı varsa yukarı itilebilir
                            if (counterp == 2) push = true;
                            // Duvar kontrolü eklenmiş olan for döngüsü
                            for (int n = counterp - 1; n > 1; n--)
                            {
                                //iki iki kontrol ederek sondan azalan veya eşitse itilebilir
                                if (int.TryParse(a[pi - n, pj], out temp) &&
                                    int.Parse(a[pi - n, pj]) <= int.Parse(a[pi - n + 1, pj]))
                                {
                                    push = true;
                                }
                                //diğer durumlarda itilemez ve break atar.
                                else
                                {
                                    push = false;
                                    break;
                                }
                            }
                            //smash kontrolü
                            if (counterp == 2) smash = false;
                            else if (counterp > 2) smash = true;

                            //dizinin üstü boşsa ve azalansa
                            if (a[pi - counterp, pj] == " " && push)
                            {
                                // Sondan başlayarak tüm sayıları yukarıya kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi - n + 1, pj], out temp))
                                    {
                                        a[pi - n + 1, pj] = " ";
                                        a[pi - n, pj] = temp.ToString();
                                        Console.SetCursorPosition(pj, pi - n + 1);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj, pi - n);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }

                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pi--;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }

                            //sayının üstü duvarsa, azalansa ve smash edilebilirse
                            else if (a[pi - counterp, pj] == "#" && smash && push)
                            {
                                //Puanlama
                                if (a[pi - counterp + 1, pj] == "0")
                                {
                                    gameScore += 20;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi - counterp + 1, pj] == "1" || a[pi - counterp + 1, pj] == "2" || a[pi - counterp + 1, pj] == "3" || a[pi - counterp + 1, pj] == "4")
                                {
                                    gameScore += 2;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi - counterp + 1, pj] == "5" || a[pi - counterp + 1, pj] == "6" || a[pi - counterp + 1, pj] == "7" || a[pi - counterp + 1, pj] == "8" || a[pi - counterp + 1, pj] == "9")
                                {
                                    gameScore += 1;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                //smash'ten sonra rastgele sayının oluşması
                                do
                                {
                                    position1 = random.Next(1, 52);
                                    position2 = random.Next(1, 22);
                                    number = random.Next(5, 10);

                                } while (a[position2, position1] != " ");
                                a[position2, position1] = number.ToString();
                                Console.SetCursorPosition(position1, position2);
                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(number); Console.ResetColor();

                                // Sondan başlayarak tüm sayıları yukarıya kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi - n + 2, pj], out temp))
                                    {
                                        a[pi - n + 2, pj] = " ";
                                        a[pi - n + 1, pj] = temp.ToString();
                                        Console.SetCursorPosition(pj, pi - n + 2);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj, pi - n + 1);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }

                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pi--;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }
                        }
                    }
                    if (cki.Key == ConsoleKey.DownArrow && pi < 21)
                    {
                        string currentCellValue = a[pi + 1, pj];

                        // Eğer currentCellValue listNumber içinde yoksa işlemi yap
                        if (!listUnTouch.Contains(currentCellValue))
                        {
                            Console.SetCursorPosition(pj, pi);
                            Console.WriteLine(" ");
                            a[pi, pj] = " ";
                            pi++;
                            a[pi, pj] = "P";
                            Console.SetCursorPosition(pj, pi);
                            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        }

                        //sayı itmesi
                        else if (numbers.Contains(currentCellValue))
                        {

                            while (a[pi + counterp, pj] != " " && a[pi + counterp, pj] != "#")
                            {
                                counterp++;
                            }
                            //bir sayı varsa aşağı itilebilir
                            if (counterp == 2) push = true;
                            // Duvar kontrolü eklenmiş olan for döngüsü
                            for (int n = counterp - 1; n > 1; n--)
                            {
                                //iki iki kontrol ederek sondan azalan veya eşitse itilebilir
                                if (int.TryParse(a[pi + n, pj], out temp) &&
                                    int.Parse(a[pi + n, pj]) <= int.Parse(a[pi + n - 1, pj]))
                                {
                                    push = true;
                                }
                                //diğer durumlarda itilemez ve break atar.
                                else
                                {
                                    push = false;
                                    break;
                                }
                            }
                            //smash kontrolü
                            if (counterp == 2) smash = false;
                            else if (counterp > 2) smash = true;

                            //dizinin aşağısı boşsa ve azalan diziyse
                            if (a[pi + counterp, pj] == " " && push)
                            {
                                // Sondan başlayarak tüm sayıları aşağıya kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi + n - 1, pj], out temp))
                                    {
                                        a[pi + n - 1, pj] = " ";
                                        a[pi + n, pj] = temp.ToString();
                                        Console.SetCursorPosition(pj, pi + n - 1);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj, pi + n);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }
                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pi++;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }

                            //sayının aşağısı duvarsa, azalansa ve smash edilebilirse
                            else if (a[pi + counterp, pj] == "#" && smash && push)
                            {
                                //puanlama
                                if (a[pi + counterp - 1, pj] == "0")
                                {
                                    gameScore += 20;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi + counterp - 1, pj] == "1" || a[pi + counterp - 1, pj] == "2" || a[pi + counterp - 1, pj] == "3" || a[pi + counterp - 1, pj] == "4")
                                {
                                    gameScore += 2;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                else if (a[pi + counterp - 1, pj] == "5" || a[pi + counterp - 1, pj] == "6" || a[pi + counterp - 1, pj] == "7" || a[pi + counterp - 1, pj] == "8" || a[pi + counterp - 1, pj] == "9")
                                {
                                    gameScore += 1;
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(" ");
                                    Console.SetCursorPosition(67, 7);
                                    Console.WriteLine(gameScore);
                                }
                                //smash'ten sonra rastgele sayının oluşması
                                do
                                {
                                    position1 = random.Next(1, 52);
                                    position2 = random.Next(1, 22);
                                    number = random.Next(5, 10);

                                } while (a[position2, position1] != " ");
                                a[position2, position1] = number.ToString();
                                Console.SetCursorPosition(position1, position2);
                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(number); Console.ResetColor();

                                // Sondan başlayarak tüm sayıları aşağı kaydırma
                                for (int n = counterp; n > 1; n--)
                                {
                                    if (int.TryParse(a[pi + n - 2, pj], out temp))
                                    {
                                        a[pi + n - 2, pj] = " ";
                                        a[pi + n - 1, pj] = temp.ToString();
                                        Console.SetCursorPosition(pj, pi + n - 2);
                                        Console.WriteLine(" ");
                                        Console.SetCursorPosition(pj, pi + n - 1);
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(temp); Console.ResetColor();
                                    }
                                }

                                Console.SetCursorPosition(pj, pi);
                                Console.WriteLine(" ");
                                a[pi, pj] = " ";
                                pi++;
                                a[pi, pj] = "P";
                                Console.SetCursorPosition(pj, pi);
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                            }
                        }
                    }
                }

                // Kronometre için gerekli kodlar

                TimeSpan elapsed = DateTime.Now - startTime;
                Console.SetCursorPosition(67, 3);

                if (elapsed.Seconds % 15 == 0 && elapsed.Milliseconds < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write($"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}");
                Console.ResetColor();
            }
        }

        static void CountdownAction(object state)   // COUNTDOWN ACTION
        {
            string[,] a = (string[,])state;
            Random random = new Random();

            for (int i = 0; i < 23; i++)
            {
                for (int j = 0; j < 53; j++)
                {
                    if (numbersDecreasing.Contains(a[i, j]))
                    {
                        // Sayı 2, 3, 4, 5, 6, 7, 8, 9 ise değerini 1 azaltsın
                        if (int.Parse(a[i, j]) > 1)
                        {

                            a[i, j] = (int.Parse(a[i, j]) - 1).ToString();
                            Console.SetCursorPosition(j, i);
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write(a[i, j]); Console.ResetColor();
                        }
                        else if (int.Parse(a[i, j]) == 1)
                        {
                            // %3 olasılıkla 1 sayısı 0 sayısına dönüşsün
                            if (random.Next(1, 101) <= 3)
                            {
                                a[i, j] = "0";
                                Console.SetCursorPosition(j, i);
                                Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                            }
                        }
                    }
                }
            }
        }

        static Random randomzeromove = new Random();
        static void SifirlarinHareketi(object state)  // MOVEMENTS OF NUMBER ZERO
        {
            string[,] a = (string[,])state;
            Random random = new Random();
            int[,] z = new int[70, 2];
            int x = 0;

            for (int i = 0; i < 23; i++)
            {
                for (int j = 0; j < 53; j++)
                {
                    if (a[i, j] == "0")
                    {
                        z[x, 0] = i;
                        z[x, 1] = j;
                        x = x + 1;
                    }
                }
            }

            for (x = 0; x < 70; x++)
            {
                int zeromove = randomzeromove.Next(1, 5);

                if (a[z[x, 0], z[x, 1]] == "0")
                {
                    if (zeromove == 1 && a[z[x, 0] + 1, z[x, 1]] == " ")
                    {
                        // Mevcut pozisyonu temizle
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");
                        // Bir sonraki pozisyona yaz
                        Console.SetCursorPosition(z[x, 1], z[x, 0] + 1);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();

                        a[z[x, 0] + 1, z[x, 1]] = "0"; // Yeni pozisyonu güncelle
                        a[z[x, 0], z[x, 1]] = " ";
                    }
                    else if (zeromove == 2 && a[z[x, 0] - 1, z[x, 1]] == " ")
                    {
                        // Mevcut pozisyonu temizle
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");

                        Console.SetCursorPosition(z[x, 1], z[x, 0] - 1);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                        a[z[x, 0] - 1, z[x, 1]] = "0";
                        a[z[x, 0], z[x, 1]] = " ";

                    }
                    else if (zeromove == 3 && a[z[x, 0], z[x, 1] - 1] == " ")
                    {
                        // Mevcut pozisyonu temizle
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");

                        Console.SetCursorPosition(z[x, 1] - 1, z[x, 0]);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                        a[z[x, 0], z[x, 1] - 1] = "0";
                        a[z[x, 0], z[x, 1]] = " ";

                    }
                    else if (zeromove == 4 && a[z[x, 0], z[x, 1] + 1] == " ")
                    {
                        // Mevcut pozisyonu temizle
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");

                        Console.SetCursorPosition(z[x, 1] + 1, z[x, 0]);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                        a[z[x, 0], z[x, 1] + 1] = "0";
                        a[z[x, 0], z[x, 1]] = " ";

                    }
                    else if (zeromove == 1 && a[z[x, 0] + 1, z[x, 1]] == "P")
                    {
                        life = life - 1;
                        a[z[x, 0], z[x, 1]] = " ";
                        a[z[x, 0] + 1, z[x, 1]] = "0";
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1], z[x, 0] + 1);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1], z[x, 0] + 1);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();

                        do
                        {
                            Random randomj = new Random();
                            pj = randomj.Next(1, 52);
                            Random randomi = new Random();
                            pi = randomi.Next(1, 22);
                        }
                        while (a[pi, pj] != " ");

                        a[pi, pj] = "P";
                        Console.SetCursorPosition(pj, pi);
                        Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(life);
                    }
                    else if (zeromove == 2 && a[z[x, 0] - 1, z[x, 1]] == "P")
                    {
                        life = life - 1;

                        a[z[x, 0] - 1, z[x, 1]] = "0";
                        a[z[x, 0], z[x, 1]] = " ";
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1], z[x, 0] - 1);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1], z[x, 0] - 1);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                        do
                        {
                            Random randomj = new Random();
                            pj = randomj.Next(1, 52);
                            Random randomi = new Random();
                            pi = randomi.Next(1, 22);
                        }
                        while (a[pi, pj] != " ");
                        a[pi, pj] = "P";
                        Console.SetCursorPosition(pj, pi);
                        Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(life);
                    }
                    else if (zeromove == 3 && a[z[x, 0], z[x, 1] - 1] == "P")
                    {
                        life = life - 1;

                        a[z[x, 0], z[x, 1] - 1] = "0";
                        a[z[x, 0], z[x, 1]] = " ";
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1] - 1, z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1] - 1, z[x, 0]);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();
                        do
                        {
                            Random randomj = new Random();
                            pj = randomj.Next(1, 52);
                            Random randomi = new Random();
                            pi = randomi.Next(1, 22);
                        }
                        while (a[pi, pj] != " ");

                        a[pi, pj] = "P";
                        Console.SetCursorPosition(pj, pi);
                        Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(life);
                    }
                    else if (zeromove == 4 && a[z[x, 0], z[x, 1] + 1] == "P")
                    {
                        life = life - 1;

                        a[z[x, 0], z[x, 1] + 1] = "0";
                        a[z[x, 0], z[x, 1]] = " ";
                        Console.SetCursorPosition(z[x, 1], z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1] + 1, z[x, 0]);
                        Console.Write(" ");
                        Console.SetCursorPosition(z[x, 1] + 1, z[x, 0]);
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black; Console.Write("0"); Console.ResetColor();

                        do
                        {
                            Random randomj = new Random();
                            pj = randomj.Next(1, 52);
                            Random randomi = new Random();
                            pi = randomi.Next(1, 22);
                        }
                        while (a[pi, pj] != " ");

                        a[pi, pj] = "P";
                        Console.SetCursorPosition(pj, pi);
                        Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("P"); Console.ResetColor();
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(67, 5);
                        Console.WriteLine(life);
                    }
                }
            }
        }
        static void gameBeginner()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.SetCursorPosition(0, 2);

            Console.WriteLine("     ▄████████   ▄████████▄  ███    ███  ████████▄  ███████████  █████████▄  ▄████████▄  ███    ███    ███  █████████▄");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███  ███   ███      ███      ███    ███  ███    ███  ███    ███    ███  ███    ███");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███  ███   ███      ███      ███    ███  ███    ███  ███    ███    ███  ███    ███");
            Console.WriteLine("     ███         ███    ███  ███    ███  ███   ███      ███      ███    ███  ███    ███  ███    ███    ███  ███    ███");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███  ███   ███      ███      ███    ███  ███    ███  ███    ███    ███  ███    ███");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███  ███   ███      ███      ███    ███  ███    ███  ███    ███    ███  ███    ███");
            Console.WriteLine("     ▀████████▀  ▀████████▀  ▀████████▀  ███   ███      ███      █████████▀  ▀████████▀  ▀███████████████▀  ███    ███");

            Console.ResetColor(); Console.SetCursorPosition(45, 15);
            Console.WriteLine("Press any key to start the game!"); Console.ReadKey(); Console.ResetColor(); Console.Clear(); Console.SetCursorPosition(49, 15);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("Game Loading ");

            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = ConsoleColor.White; Console.Write("■");
                Thread.Sleep(110);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.SetCursorPosition(0, 2);

            Console.WriteLine("     ██████████  ▄████████▄  ██████████  █████████     ███    ███");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███        ███  ████████████████");
            Console.WriteLine("     ███    ███  ███    ███  ███    ███        ███     ███    ███");
            Console.WriteLine("     ██████████  ██████████  ██████████        ███     ███    ███");
            Console.WriteLine("     ███                ███  ███    ███        ███     ███    ███");
            Console.WriteLine("     ███                ███  ███    ███        ███  ████████████████");
            Console.WriteLine("     ███         ██████████  ██████████        ███     ███    ███");

            Thread.Sleep(1000);
            Console.ResetColor(); Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.SetCursorPosition(0, 2);


            Console.WriteLine("                 ██████████  ▄████████▄  ██████████     ███    ███");
            Console.WriteLine("                 ███    ███  ███    ███  ███    ███  ████████████████");
            Console.WriteLine("                 ███    ███  ███    ███  ███    ███     ███    ███");
            Console.WriteLine("                 ██████████  ██████████  ██████████     ███    ███");
            Console.WriteLine("                 ███                ███  ███    ███     ███    ███");
            Console.WriteLine("                 ███                ███  ███    ███  ████████████████");
            Console.WriteLine("                 ███         ██████████  ██████████     ███    ███");

            Thread.Sleep(1000);
            Console.ResetColor(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.SetCursorPosition(0, 2);


            Console.WriteLine("                           ██████████  ▄████████▄       ███    ███");
            Console.WriteLine("                           ███    ███  ███    ███    ████████████████");
            Console.WriteLine("                           ███    ███  ███    ███       ███    ███");
            Console.WriteLine("                           ██████████  ██████████       ███    ███");
            Console.WriteLine("                           ███                ███       ███    ███");
            Console.WriteLine("                           ███                ███    ████████████████");
            Console.WriteLine("                           ███         ██████████       ███    ███");

            Thread.Sleep(1000);
            Console.ResetColor(); Console.Clear();

        }
    }
}