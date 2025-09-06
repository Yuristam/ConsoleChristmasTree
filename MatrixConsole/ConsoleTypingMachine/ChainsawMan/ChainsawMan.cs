using System.Media;
using static ConsoleTypingMachine.ChainsawMan.ChainsawManPeople;

namespace ConsoleTypingMachine.ChainsawMan
{
    public class ChainsawMan
    {
        public static void GunDevil()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                string spoiler = "SPOILER ALERT";
                Console.WriteLine(spoiler);
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.ResetColor();
            
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer typingSound = new SoundPlayer(@"ChainsawMan\Keyboard Typing.wav");

                typingSound.Load();
                typingSound.PlayLooping();
                
                string date = "September 12, 1997 3:18:21 P.M.";
                
                date.ToCharArray();
                
                for (int i = 0; i < date.Length; i++)
                {
                    Console.Write(date[i]);
                    Thread.Sleep(50);
                }
                
                Thread.Sleep(1000);
                Console.Clear();
                
                string record1 = "The ";
                record1.ToCharArray();
                
                for (int i = 0; i < record1.Length; i++)
                {
                    Console.Write(record1[i]);
                    Thread.Sleep(50);
                }
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                
                string recordRed1 = "GUN DEVIL ";
                recordRed1.ToCharArray();
                
                for (int i = 0; i < recordRed1.Length; i++)
                {
                    Console.Write(recordRed1[i]);
                    Thread.Sleep(50);
                }
                
                Console.ResetColor();
                
                string record2 = "hits the city of \r\n" +
                    "Nikaho in Akita Prefecture, Japan \r\n" +
                    "from off the coast for ";
                record2.ToCharArray();

                for (int i = 0; i < record2.Length; i++)
                {
                    Console.Write(record2[i]);
                    Thread.Sleep(50);
                }
                
                Console.ForegroundColor = ConsoleColor.DarkRed;

                string recordRed2 = "12 seconds.";
                recordRed2.ToCharArray();

                for (int i = 0; i < recordRed2.Length; i++)
                {
                    Console.Write(recordRed2[i]);
                    Thread.Sleep(50);
                }

                Thread.Sleep(2000);
                Console.ResetColor();
                Console.Clear();

                string ability = "Immediately upon appearance: ability activation. Ability to fire a bullet through the head \r\n" +
                    "of every adult male within approximately 1,000 meters of the Gun Devil \r\n" +
                    "confirmed." +
                    "\r\n\r\nAbility to fire a bullet through the head of every child (ages 0-12) within approximately \r\n" +
                    "1,500 meters of the Gun Devil confirmed.";
                ability.ToCharArray();

                for (int i = 0; i < ability.Length; i++)
                {
                    Console.Write(ability[i]);
                    Thread.Sleep(50);
                }

                Thread.Sleep(2000);
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                string[] peopleArray1 = new string[] { people1, people2, people3, people4, people5 };

                for (int i = 0; i < peopleArray1.Length; i++)
                {
                    peopleArray1[i].ToCharArray();

                    for (int k = 0; k < peopleArray1[i].Length; k++)
                    {
                        Console.Write(peopleArray1[i][k]);
                        Thread.Sleep(1);
                    }

                    Console.Clear();
                }

                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);

                string[] peopleArray2 = new string[] { people6, people7 };

                for (int i = 0; i < peopleArray2.Length; i++)
                {
                    peopleArray2[i].ToCharArray();

                    for (int k = 0; k < peopleArray2[i].Length; k++)
                    {
                        Console.Write(peopleArray2[i][k]);
                        Thread.Sleep(1);
                    }

                    Console.Clear();
                }

                Thread.Sleep(1000);
                Console.ResetColor();
                
                string date2 = "3:18:22\r\nThe Gun Devil advances toward Makima.";
                date2.ToCharArray();

                for (int i = 0; i < date2.Length; i++)
                {
                    Console.Write(date2[i]);
                    Thread.Sleep(50);
                }

                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < peopleArray3.Length; i++)
                {
                    Console.Write(peopleArray3[i]);
                    Thread.Sleep(50);

                    if (i == 27)
                    {
                        Console.Clear();
                    }
                    else if (i == 54)
                    {
                        Console.Clear();
                    }
                    else if (i == 81)
                    {
                        Console.Clear();
                    }
                    else if (i == 108)
                    {
                        Console.Clear();
                    }
                    else if (i == 135)
                    {
                        Console.Clear();
                    }
                    else if (i == 162)
                    {
                        Console.Clear();
                    }
                    else if (i == 189)
                    {
                        Console.Clear();
                    }
                    else if (i == 216)
                    {
                        Console.Clear();
                    }
                    else if (i == 243)
                    {
                        Console.Clear();
                    }
                }

                Console.Clear();
                Console.ResetColor();

                string date3 = "3:18:23\r\n\r\nMakima sights the Gun Devil\r\nat a distance of 500 kilometers.";
                date3.ToCharArray();

                for (int i = 0; i < date3.Length; i++)
                {
                    Console.Write(date3[i]);
                    Thread.Sleep(50);
                }

                Thread.Sleep(1000);
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.DarkRed;

                string[] peopleArray4 = new string[] { people8, people9 };

                for (int i = 0; i < peopleArray4.Length; i++)
                {
                    peopleArray4[i].ToCharArray();

                    for (int k = 0; k < peopleArray4[i].Length; k++)
                    {
                        Console.Write(peopleArray4[i][k]);
                        Thread.Sleep(10);
                    }

                    Console.Clear();
                }

                Thread.Sleep(1000);
                Console.ResetColor();
                
                string date4 = "3:18:24\r\n\r\nGun Devil ability activation:\r\n" +
                    "Ability to fire a bullet through the heart\r\n" +
                    "of every living thing born in the months of\r\n" +
                    "January, February, March, May, June, August, September, November or\r\n" +
                    "December within approximately one kilometer confirmed.";
                date4.ToCharArray();

                for (int i = 0; i < date4.Length; i++)
                {
                    Console.Write(date4[i]);
                    Thread.Sleep(50);
                }

                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                string[] peopleArray5 = new string[] { people10, people11 };

                for (int i = 0; i < peopleArray5.Length; i++)
                {
                    peopleArray5[i].ToCharArray();

                    for (int k = 0; k < peopleArray5[i].Length; k++)
                    {
                        Console.Write(peopleArray5[i][k]);
                        Thread.Sleep(20);
                    }

                    Console.Clear();
                }

                Thread.Sleep(1000);
                Console.ResetColor();

                string date5 = "3:18:25\r\n\r\nThe Gun Devil stops.\r\nGun Devil ability activation: gunfire toward Makima begins.";
                date5.ToCharArray();

                for (int i = 0; i < date5.Length; i++)
                {
                    Console.Write(date5[i]);
                    Thread.Sleep(50);
                };

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < peopleArray6.Length; i++)
                {
                    Console.Write(peopleArray6[i]);
                    Thread.Sleep(200);

                    for (int j = 0; j < i; j++)
                    {
                        Console.Clear();
                    }
                }

                Console.ResetColor();

                string date6 = "3:18:26\r\n\r\nMakima prepares for ability activation.";
                date6.ToCharArray();

                for (int i = 0; i < date6.Length; i++)
                {
                    Console.Write(date6[i]);
                    Thread.Sleep(50);
                };

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < peopleArray7.Length; i++)
                {
                    Console.Write(peopleArray7[i]);
                    Thread.Sleep(200);

                    for (int j = 0; j < i; j++)
                    {
                        Console.Clear();
                    }
                }

                Console.ResetColor();
                
                string date7 = "Makima's 29th recorded death.\r\n\r\n3:18:27";
                date7.ToCharArray();

                for (int i = 0; i < date7.Length; i++)
                {
                    Console.Write(date7[i]);
                    Thread.Sleep(50);
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < peopleArray8.Length; i++)
                {
                    Console.Write(peopleArray8[i]);
                    Thread.Sleep(200);

                    for (int j = 0; j < i; j++)
                    {
                        Console.Clear();
                    }
                }

                Console.ResetColor();
                
                string[] date8 = new string[] {
                         "Makima ability activation:\r\n\r\nUse of the following's abilities.",
                         "Yutaro Kurose and Michiko Tendo's antemortem Devil contract, Punishment Devil\r\n" +
                         "Akane Sawatari's antemortem Devil contract, Snake Devil\r\n" +
                         "Aki Hayakawa's antemortem Devil contract, Future Devil",
                         "Angel Devil",
                         "Spider Devil",
                         "3:18:28"
                };

                for (int i = 0; i < date8.Length; i++)
                {
                    Thread.Sleep(1000);
                    Console.Clear();

                    date8[i].ToCharArray();

                    for (int j = 0; j < date8[i].Length; j++)
                    {
                        Console.Write(date8[i][j]);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine();
                }

                typingSound.Stop();
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;

            string door = @"  _____              _ _                              _   _                _                  
 |█████\            (█)█|                            |█| |█|              |█|                 
 |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
 |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
 |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
 |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                  |█|                                                         
                                  |█|  ";
            string door2 = @"   _____              _ _                              _   _                _                  
  |█████\            (█)█|                            |█| |█|              |█|                 
  |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
  |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
  |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
  |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                   |█|                                                         
                                   |█|  ";
            string door3 = @"    _____              _ _                              _   _                _                  
   |█████\            (█)█|                            |█| |█|              |█|                 
   |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
   |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
   |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
   |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                    |█|                                                         
                                    |█|  ";
            string door4 = @"
   _____              _ _                              _   _                _                  
  |█████\            (█)█|                            |█| |█|              |█|                 
  |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
  |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
  |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
  |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                   |█|                                                         
                                   |█|  ";

            string[] doorArray = new string[] {
                door, door2, door3, door2, door4, door2
            };

            for (int k = 0; k < 10; k++)
            {

                for (int i = 0; i < doorArray.Length; i++)
                {
                    Console.WriteLine(doorArray[i]);
                    Thread.Sleep(20);
                    Console.Clear();
                }

                Thread.Sleep(20);
            }
            Console.ResetColor();
        }
    }
}
