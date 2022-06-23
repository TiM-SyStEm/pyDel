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
        public int SizeX;
        public int SizeY;

        public float ScaleMapDoc;
        public string ScaleMD;
        public string ScaleMSW;

        public string DoText;

        public Setting()
        {
            InitializeComponent();
            visibleFalse();
        }
        private void visibleFalse(){
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }
        private void visibleTrue(){
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            visibleTrue();
            textBox1.Text = ScaleMD;
            textBox2.Text = ScaleMSW;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visibleFalse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visibleFalse();
            ScaleMapDoc = Convert.ToSingle(textBox1.Text);
            Form1 f1 = new Form1();
            f1.documentMap1.Scale = ScaleMapDoc;
            f1.fastColoredTextBox1.Text = DoText;
            f1.documentMap1.Size = new Size(Convert.ToInt32(textBox2.Text), f1.documentMap1.Size.Height);
            f1.Size = new Size(SizeX, SizeY);
            f1.Show();
            Hide();
        }
    }
}
