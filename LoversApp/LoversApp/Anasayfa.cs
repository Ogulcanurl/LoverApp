using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoversApp
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            sidePanel.Height = buttonHome.Height;
            galeri1.Hide();
        }

        private void buttonGallery_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonGallery.Height;
            sidePanel.Top = buttonGallery.Top;
            galeri1.Show();
            galeri1.BringToFront();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            sidePanel.Top = buttonHome.Top;
            sidePanel.Height = buttonHome.Height;
            galeri1.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
