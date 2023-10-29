using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1pract
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                Arrays a = new Arrays(n);
                for (int i = 0; i < a.Lenght; i++)
                {
                    dataGridView1.Rows.Add(a[i].ToString());
                }

                var min = a.FirstNegativeTemperatureIndex();

                label1.Text = min.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
