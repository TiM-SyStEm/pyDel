using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyDEL
{
    public partial class Setting : Form
    {
        public bool isOkDoc = false;

        public float ScaleMapDoc;

        public string DoText;

        public Setting()
        {
            InitializeComponent();
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button3.Visible = false;
            isOkDoc = true;
            ScaleMapDoc = Convert.ToSingle(textBox1.Text);
            Form1 f1 = new Form1();
            f1.documentMap1.Scale = ScaleMapDoc;
            f1.Show();
            f1.fastColoredTextBox1.Text = DoText;
            Hide();
        }
    }
}
