using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._7可选列表框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox1.Items)
            {
                checkedListBox2.Items.Add(o);
            }
            checkedListBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItems.Count < 1)
            {
                return;
            }
            checkedListBox2.Items.Add(checkedListBox1.SelectedItem);
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.SelectedItems.Count < 1)
            {
                return;
            }
            checkedListBox1.Items.Add(checkedListBox2.SelectedItem);
            checkedListBox2.Items.Remove(checkedListBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox2.Items)
            {
                checkedListBox1.Items.Add(o);
            }
            checkedListBox2.Items.Clear();
        }
    }
}
