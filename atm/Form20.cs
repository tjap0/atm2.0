﻿using System;
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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //pogu citai darbība
            this.Hide();
            Form fr7 = new Form7();
            fr7.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("atm-machine-beep-button-push_zjokxned.wav");
            player.Play();

            //izejas poga
            this.Hide();
            Form fr12 = new Form12();
            fr12.Show();
        }
    }
}
