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
    public partial class Form3 : Form
    {
        public Form3()
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
            try
            {
                int n = 0, m = 0;

                n = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox2.Text);

                Arrays2D twoDimArray = new Arrays2D(n, m);
                DataGridViewTextBoxColumn dvage;

                for (int i = 0; i < m; i++)
                {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;               
                    dataGridView1.Columns.Add(dvage);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = twoDimArray.X_Lenght;
                dataGridView1.ColumnCount = twoDimArray.Y_Lenght;

                for (int i = 0; i < twoDimArray.X_Lenght; i++)
                {
                    for (int j = 0; j < twoDimArray.Y_Lenght; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = twoDimArray[i, j].ToString();
                    }
                }
                var result = twoDimArray.FindMaxElement;

                label1.Text = result.Item1.ToString();
                label2.Text = result.Item2.ToString();
                label3.Text = result.Item3.ToString();


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }    

        }
    }
}
