using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы не сомневались, что Вы так думаете!");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Top -= e.Y;
            button1.Top += e.X;
            if (button1.Top < -10 || button1.Top > 100)
                button1.Top = 60;
            if (button1.Left < -80 || button1.Left > 250)
                button1.Left = 120;
        }
    }
}
