using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArminTradeJob
{
    public partial class averageNumbers : Form
    {
        List<int> list = new List<int>();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

       
        public averageNumbers()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
          

            if (numTextBox.Text.Length == 0) {
                MessageBox.Show("Nem írt be számot!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numTextBox.Text.Length == 0)
            {
                MessageBox.Show("Nem írt be számot!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int parseInt;
            if (!int.TryParse(numTextBox.Text, out parseInt))
            {
                MessageBox.Show("Nem számot írt be!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int input = Convert.ToInt32(numTextBox.Text);
                list.Add(input);
            this.dataGridView1.DataSource = list.Select(k => new { Value = k }).ToList();
           

        }

        private void averageBtn_Click(object sender, EventArgs e)
        {
            
            if (list.Count<=1 )
            {
                MessageBox.Show("Kevés a bevitt szám!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int darab = list.Count;
            double average = list.Average();
            MessageBox.Show("Az átlag:" + average.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;


        }
    }
}
