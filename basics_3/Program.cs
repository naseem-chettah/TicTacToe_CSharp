using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace basics_3
{
    class project
    {
        //Quit Console Statments
        static void Quit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Press <Enter> To Quit.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        //The Main Code
        public static void Main(string[] args)
        {
            int play = 0;
            var turn = true; var win = false;
            char[] a = { '1', '2', '3' };
            char[] b = { '4', '5', '6' };
            char[] c = { '7', '8', '9' };
            UserInput(play, a, b, c, turn, win);
            Quit();
        }
        //UI
        static void UserInput(int play, char[] a, char[] b, char[] c, bool turn, bool win)
        {
            int gamePlayed = 0;
            while (!(win) && gamePlayed < 9)
            {
                while (play < 1 || play > 9)
                {
                    Console.Clear();
                    PrintPlayBoard(a, b, c);
                    try
                    {
                        Console.Write("Enter an integer: ");
                        play = int.Parse(Console.ReadLine());
                        switch (play)
                        {
                            case 1:
                                if (a[0]=='1')
                                {
                                    if (turn) a[0] = 'X';
                                    else a[0] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 2:
                                if (a[1] == '2')
                                {
                                    if (turn) a[1] = 'X';
                                    else a[1] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 3:
                                if (a[2] == '3')
                                {
                                    if (turn) a[2] = 'X';
                                    else a[2] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 4:
                                if (b[0] == '4')
                                {
                                    if (turn) b[0] = 'X';
                                    else b[0] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 5:
                                if (b[1] == '5')
                                {
                                    if (turn) b[1] = 'X';
                                    else b[1] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 6:
                                if (b[2] == '6')
                                {
                                    if (turn) b[2] = 'X';
                                    else b[2] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 7:
                                if (c[0] == '7')
                                {
                                    if (turn) c[0] = 'X';
                                    else c[0] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 8:
                                if (c[1] == '8')
                                {
                                    if (turn) c[1] = 'X';
                                    else c[1] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                            case 9:
                                if (c[2] == '9')
                                {
                                    if (turn) c[2] = 'X';
                                    else c[2] = 'O';
                                    turn = !(turn);
                                    gamePlayed += 1;
                                }
                                break;
                        }
                        Console.Clear();
                        PrintPlayBoard(a, b, c);
                    }
                    catch
                    {
                        Console.WriteLine("error 1101: wtf are you doing? I asked for a DAMN INTEGER!!!!");
                    }
                }
                if (a[0] == a[1] && a[0] == a[2]) win = true;
                if (b[0] == b[1] && b[0] == b[2]) win = true;
                if (c[0] == c[1] && c[0] == c[2]) win = true;
                if (a[0] == b[0] && a[0] == c[0]) win = true;
                if (a[1] == b[1] && a[1] == c[1]) win = true;
                if (a[2] == b[2] && a[2] == c[2]) win = true;
                if (a[0] == b[1] && a[0] == c[2]) win = true;
                if (a[2] == b[1] && a[2] == c[0]) win = true;
                play = 0;
            }
            if (turn && win) Console.WriteLine("O WINS");
            else if (!(turn) && win) Console.WriteLine("X WINS");
            else if (!(win)) Console.WriteLine("EVEN!");
        }
        //Print The Play Board
        static void PrintPlayBoard(char[] a, char[] b, char[] c)
        {
            int i;
            for(i = 0; i<3; i++)
            {
                Console.Write(a[i]);
                if(i != 2) Console.Write("--");
            }
            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                Console.Write(b[i]);
                if (i != 2) Console.Write("--");
            }
            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                Console.Write(c[i]);
                if (i != 2) Console.Write("--");
            }
            Console.WriteLine();
        }
    }
    
    
}