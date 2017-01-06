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
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_StorageDataSet.dbo_ТОВАРЫ". При необходимости она может быть перемещена или удалена.
            //this.dbo_ТОВАРЫTableAdapter.Fill(this.dB_StorageDataSet.dbo_ТОВАРЫ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._2Данные". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Акт". При необходимости она может быть перемещена или удалена.
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

      private void trorloloToolStripMenuItem_Click(object sender, EventArgs e){}

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void актыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 акт = new Form2();
            акт.Show();
        }

        private void выйтиСУчёткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization from = new Authorization();
            from.ShowDialog();
            this.Close();
        }

        private void стоимостьИнвентаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dannie form = new Dannie();
            form.Show();
        }
    }

}
