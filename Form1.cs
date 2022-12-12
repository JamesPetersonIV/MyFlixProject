using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlixProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedMs.Text = "";
            foreach (object movies in listBox1.SelectedItems)
            {
                selectedMs.Text += (selectedMs.Text == "" ? "" : ",") + movies.ToString();
            }


            int totalMovies = listBox1.SelectedItems.Count;
            movieCount.Text = "No. Of Selections: " + totalMovies.ToString();

            double pricesForSelection = totalMovies * 1.99;
            totalPrice.Text = "Total Price: " + pricesForSelection.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }

        private void movieCount_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
