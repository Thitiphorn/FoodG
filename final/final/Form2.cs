using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nut;
            bool a = int.TryParse(Tb_fg.Text, out nut);
            if (Tb_fg.Text == "")
            {
                MessageBox.Show("กรอกใหม่");
            }
            else if (a == false)
            {
                MessageBox.Show("กรอกใหม่");
            }
            else
            {
                File.WriteAllText("Number.txt", Tb_fg.Text);
                Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Tb_fg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
