using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3jankenGUI
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3janken
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            
            
           
            janken G = new janken();
            janken T = new janken();
            janken P = new janken();

            while (true)
            {

            Console.WriteLine("JANKEN START!!");
            Console.WriteLine("（Ｇ）1✊（Ｔ）2✌（Ｐ）3✋を選んでください");
            
            string ns=Console.ReadLine();
            int s = int.Parse(ns);
            Console.WriteLine("あなたが選んだのは" + s + "です");
            Console.WriteLine("4があいこで5が勝ち6が負け");
            if (s == 1) {
                G.Gu();
                Console.WriteLine(G);
            }
            else if (s == 2) { T.Tyoki(); Console.WriteLine(T); }
            else if(s==3) { P.Pa(); Console.WriteLine(P); }


            }


        }
    }
    class janken
    {
        
       
        
        Random r = new Random();
        public int aiko=4;
        public int kati=5;
        public int make=6;
        public int ans;
        public int cpu;


        public void Gu()
        {
            int random=r.Next(0,3);
            if(random==0)
            {
                ans = aiko;
            }
            else if (random == 1) { ans=kati; }
            else if (random == 2) { ans=make; }
            Console.WriteLine("CPUは" + random + "を選びました。");
            Console.WriteLine("結果は"+ans);

        }
        public void Tyoki()
        {
            int random=r.Next(0,3);
            if (random == 0) {  ans=make; }
            else if (random == 1) {  ans=aiko; }
            else if(random == 2) { ans=kati; }
            Console.WriteLine("CPUは" + random + "を選びました。");
            Console.WriteLine(ans);
        }
        public void Pa()
        {
            int random=r.Next(0,3);
            if (random == 0) { ans=kati; }
            else if(random == 1) { ans=make; }
            else if (random == 2) { ans=aiko; }
            Console.WriteLine("CPUは" + random + "を選びました。");
            Console.WriteLine(ans);
        }


    }
   
}
 */
