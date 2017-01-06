using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    this.Hide();
                    main_Form main_Form = new main_Form();
                    main_Form.ShowDialog();
                    this.Close();
                   
                }
            }
            else
                MessageBox.Show("Неверный логин/пароль");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();

            main_Form main_Form = new main_Form();
            main_Form.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
