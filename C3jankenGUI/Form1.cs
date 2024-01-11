using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3jankenGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        




        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void GU_Click(object sender, EventArgs e)
        {
            int ans;
            CPU GU = new CPU();
            ans = GU.cpu();
            for (int i = 0; i < 3; i++)
            {
                if (ans == 0) { label1.Text = "cpuが" + ans + "（✊）なのであいこ"; }
                else if (ans == 1) { label1.Text = "cpuが" + ans + "（✌）なのであなたの勝ち"; }
                else if (ans == 2) { label1.Text = "cpuが" + ans + "（✋）なのであなたの負け"; }
            }
            //label1.Text="CPUは"+GU +"を選びました";
        }

        private void TYOKI_Click(object sender, EventArgs e)
        {
            CPU TYOKI = new CPU();
            int ans;
            ans = TYOKI.cpu();
            for (int i = 0; i < 3; i++)
            {
                if (ans == 0) { label1.Text = "cpuが" + ans + "（✊）なのであなたの負け"; }
                else if (ans == 1) { label1.Text = "cpuが" + ans + "（✌）引き分け"; }
                else if (ans == 2) { label1.Text = "cpuが" + ans + "（✋）なのであなたの勝ち"; }
            }
            //label1.Text = "CPUは" + TYOKI + "を選びました";
        }

        private void PA_Click(object sender, EventArgs e)
        {
            CPU PA = new CPU();
            int ans;
            ans = PA.cpu();
            for (int i = 0; i < 3; i++)
            {
                if (ans == 0) { label1.Text = "cpuが" + ans + "（✊）なのであなたの勝ち"; }
                else if (ans == 1) { label1.Text = "cpuが" + ans + "（✌）なのであなたの負け"; }
                else if (ans == 2) { label1.Text = "cpuが" + ans + "（✋）なのであいこ"; }
            }
            //label1.Text = "CPUは" + PA + "を選びました";
        }

        
    }
    public class CPU
    {
        public int cpu()
        {
            Random r = new Random();
            int random = r.Next(0, 3);
            return random;
        }
    }
}


