using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //pogu citai darbība
            this.Hide();
            Form fr8 = new Form8();
            fr8.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //izejas poga
            this.Hide();
            Form12 fr12 = new Form12();
            fr12.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
