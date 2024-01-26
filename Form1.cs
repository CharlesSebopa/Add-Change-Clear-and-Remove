using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();
            listBox1.Items.Add(newWord);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();
            listBox1.Items[listBox1.SelectedIndex] = newWord;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
