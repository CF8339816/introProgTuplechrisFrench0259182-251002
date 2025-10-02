using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace introProgTuplechrisFrench0259182_251002
{
    internal class Program
    {
        static (int, int)[] raindrops = { (5, 5), (14, 5), (21, 5), (27, 9), (12, 9), (25, 9) };
       // static (int, int) myValueTuple = (5, 10);
        static void Main(string[] args)
        {
            //Random random = new Random();
           // int randNum = random.Next();
            Console.CursorVisible = false;
            //myValueTuple.Item1 = 15;
            //myValueTuple.Item2 = 20;

           
           
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);

            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();

            Cyan();

            Yellow(); 
            Cyan();

            Yellow();

            Red();
            Cyan();

            Yellow();

            Red();
            Red();


            Cyan();
            Cyan();

            Yellow();

            Red();
            Yellow();
            Cyan();
            Red();
        }

        static void Cyan()
        {
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);

            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
        }

        static void Yellow()
        {
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);

            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
        }

        static void Red()
        {
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[0].Item1, raindrops[0].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);

            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[1].Item1, raindrops[1].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[2].Item1, raindrops[2].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[3].Item1, raindrops[3].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[4].Item1, raindrops[4].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            // Console.Clear();
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("o");
            Thread.Sleep(200);//delays the process of next line 
            Console.SetCursorPosition(raindrops[5].Item1, raindrops[5].Item2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("o");
            Thread.Sleep(30);
            //Console.Clear();
        }
    }
}
