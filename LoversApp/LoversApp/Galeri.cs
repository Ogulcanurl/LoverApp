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
    public partial class Galeri : UserControl
    {
        public Galeri()
        {
            InitializeComponent();
        }



        public void objectHide() {

            buttonEnterDate.Hide();
            buttonSelectDate.Hide();
            dateTimePickerSelect.Hide();
            buttonSeeAll.Hide();
            textBoxEnterDate.Hide();

        }


        int a = 0;
        int select = 0;
        int filter = 0;
        public void Filter(Button e, Button b, Button c)
        {

            filter++;
            if (filter == 3)
            {
                filter = 1;
            }
            if (filter == 1)
            {
                e.Show();
                b.Show();
                c.Show();

            }
            if (filter == 2)
            {
                objectHide();
            }
        }
        public void objectIfSelect(Button e, Button b, Button c, TextBox t, DateTimePicker d)
        {
            select++;
            if (select == 3)
            {
                select = 1;
            }
            if (select == 1)
            {
                e.Hide();
                c.Hide();
                d.Show();
                t.Hide();
                d.Location = new Point(14, 265);
                b.Location = new Point(14, 205);
            }
            if (select == 2)
            {
                e.Show();
                c.Show();
                d.Hide();
                b.Location = new Point(10, 128);
                b.Margin = new Padding(3, 3, 3, 3);
            }
        }

        public void objectIfEnter(Button e, Button b, Button c, TextBox t, DateTimePicker d)
        {
            a++;
            if (a == 3)
            {
                a = 1;
            }
            if (a == 1)
            {
                e.Hide();
                c.Hide();
                t.Show();
                d.Hide();
                t.Location = new Point(10, 265);
                b.Location = new Point(10, 205);
            }
            if (a == 2)
            {
                e.Show();
                c.Show();
                t.Hide();
                b.Location = new Point(10, 193);
                b.Margin = new Padding(3, 3, 3, 3);
            }
        }
        private void Galeri_Load(object sender, EventArgs e)
        {
            objectHide();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter(buttonSeeAll, buttonSelectDate, buttonEnterDate);

        }
        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            objectIfSelect(buttonEnterDate, buttonSelectDate, buttonSeeAll, textBoxEnterDate, dateTimePickerSelect);
        }

        private void buttonEnterDate_Click(object sender, EventArgs e)
        {
            objectIfEnter(buttonSelectDate, buttonEnterDate, buttonSeeAll, textBoxEnterDate, dateTimePickerSelect);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
