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
    public partial class Dannie : Form
    {
        public Dannie()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dannie_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._2Стоимост". При необходимости она может быть перемещена или удалена.
            this._2СтоимостTableAdapter.Fill(this.kursDataSet._2Стоимост);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._2Данные". При необходимости она может быть перемещена или удалена.
            this._2ДанныеTableAdapter.Fill(this.kursDataSet._2Данные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Акт". При необходимости она может быть перемещена или удалена.
            this.актTableAdapter.Fill(this.kursDataSet.Акт);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._2ДанныеTableAdapter.Update(this.kursDataSet);
            this._2СтоимостTableAdapter.Update(this.kursDataSet);
            this.актTableAdapter.Update(this.kursDataSet);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._2Стоимост". При необходимости она может быть перемещена или удалена.
            this._2СтоимостTableAdapter.Fill(this.kursDataSet._2Стоимост);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._2Данные". При необходимости она может быть перемещена или удалена.
            this._2ДанныеTableAdapter.Fill(this.kursDataSet._2Данные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Акт". При необходимости она может быть перемещена или удалена.
            this.актTableAdapter.Fill(this.kursDataSet.Акт);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
