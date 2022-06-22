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
using System.Diagnostics;

namespace pyDEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void openTheThemeEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Setting set = new Setting();
            set.Show();
            set.DoText = fastColoredTextBox1.Text;
        }
    }
}
