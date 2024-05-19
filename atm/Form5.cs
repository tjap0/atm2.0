using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnKonta_Click(object sender, EventArgs e)
        {
        }

        private void labNumbers_Click(object sender, EventArgs e)
        {
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            //slēpt bankas kontu
            labNumbers.Text = "**********************";
            button1.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            ////pogu citai darbībai
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            ////izejas poga
            this.Hide();
            Form fr18 = new Form18();
            fr18.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            //noteikt, kura parole ir ievadīta Ienakt formā
            if (global.astr == global1.psw1)
            {
                button1.Hide();
                labNumbers.Text = global1.balance1 + " €";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                labNumbers.Text = global2.balance2 + " €";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                labNumbers.Text = global3.balance3 + " €";
            }
            else
            {
                button1.Hide();
                labNumbers.Text = global4.balance4 + " €";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");
            
            if (global.astr == global1.psw1)
            {
                button1.Hide();
                double gb1 = Convert.ToDouble(global1.balance1);
                labNumbers.Text = gb1 * 1.09 + "$";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                double gb2 = Convert.ToDouble(global2.balance2);
                labNumbers.Text = gb2 * 1.09 + "$";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                double gb3 = Convert.ToDouble(global3.balance3);
                labNumbers.Text = gb3 * 1.09 + "$";
            }
            else
            {
                button1.Hide();
                double gb4 = Convert.ToDouble(global4.balance4);
                labNumbers.Text = gb4 * 1.09 + "$";
            }
        }

        private void button_jopen_money_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            if (global.astr == global1.psw1)
            {
                button1.Hide();
                double gb1 = Convert.ToDouble(global1.balance1);
                labNumbers.Text = gb1 * 7.85 + "¥";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                double gb2 = Convert.ToDouble(global2.balance2);
                labNumbers.Text = gb2 * 7.85 + "¥";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                double gb3 = Convert.ToDouble(global3.balance3);
                labNumbers.Text = gb3 * 7.85 + "¥";
            }
            else
            {
                button1.Hide();
                double gb4 = Convert.ToDouble(global4.balance4);
                labNumbers.Text = gb4 * 7.85 + "¥";
            }
        }

        private void button_russian_money_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            if (global.astr == global1.psw1)
            {
                button1.Hide();
                double gb1 = Convert.ToDouble(global1.balance1);
                labNumbers.Text = gb1 * 98.76 + "₽";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                double gb2 = Convert.ToDouble(global2.balance2);
                labNumbers.Text = gb2 * 98.76 + "₽";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                double gb3 = Convert.ToDouble(global3.balance3);
                labNumbers.Text = gb3 * 98.76 + "₽";
            }
            else
            {
                button1.Hide();
                double gb4 = Convert.ToDouble(global4.balance4);
                labNumbers.Text = gb4 * 98.76 + "₽";
            }
        }

        private void button_england_money_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            if (global.astr == global1.psw1)
            {
                button1.Hide();
                double gb1 = Convert.ToDouble(global1.balance1);
                labNumbers.Text = gb1 * 0.86 + "£";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                double gb2 = Convert.ToDouble(global2.balance2);
                labNumbers.Text = gb2 * 0.86 + "£";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                double gb3 = Convert.ToDouble(global3.balance3);
                labNumbers.Text = gb3 * 0.86 + "£";
            }
            else
            {
                button1.Hide();
                double gb4 = Convert.ToDouble(global4.balance4);
                labNumbers.Text = gb4 * 0.86 + "£";
            }
        }
    }
}
