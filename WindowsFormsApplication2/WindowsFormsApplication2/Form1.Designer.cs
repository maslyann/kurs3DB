namespace WindowsFormsApplication2
{
    partial class main_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form));
            this.dboТОВАРЫBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стоимостьИнвентаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работасданнымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиСУчёткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dboТОВАРЫBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dboТОВАРЫBindingSource
            // 
            this.dboТОВАРЫBindingSource.DataMember = "dbo_ТОВАРЫ";
            this.dboТОВАРЫBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.работасданнымиToolStripMenuItem,
            this.опрограммеToolStripMenuItem,
            this.выйтиСУчёткиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актыToolStripMenuItem,
            this.стоимостьИнвентаряToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.trorloloToolStripMenuItem_Click);
            // 
            // актыToolStripMenuItem
            // 
            this.актыToolStripMenuItem.Name = "актыToolStripMenuItem";
            this.актыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.актыToolStripMenuItem.Text = "Акты";
            this.актыToolStripMenuItem.Click += new System.EventHandler(this.актыToolStripMenuItem_Click);
            // 
            // стоимостьИнвентаряToolStripMenuItem
            // 
            this.стоимостьИнвентаряToolStripMenuItem.Name = "стоимостьИнвентаряToolStripMenuItem";
            this.стоимостьИнвентаряToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.стоимостьИнвентаряToolStripMenuItem.Text = "Стоимость инвентаря";
            this.стоимостьИнвентаряToolStripMenuItem.Click += new System.EventHandler(this.стоимостьИнвентаряToolStripMenuItem_Click);
            // 
            // работасданнымиToolStripMenuItem
            // 
            this.работасданнымиToolStripMenuItem.Name = "работасданнымиToolStripMenuItem";
            this.работасданнымиToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.работасданнымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.опрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выйтиСУчёткиToolStripMenuItem
            // 
            this.выйтиСУчёткиToolStripMenuItem.Name = "выйтиСУчёткиToolStripMenuItem";
            this.выйтиСУчёткиToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.выйтиСУчёткиToolStripMenuItem.Text = "Выйти с учётки";
            this.выйтиСУчёткиToolStripMenuItem.Click += new System.EventHandler(this.выйтиСУчёткиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(596, 396);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_Form";
            this.Text = "ИС \"Курс\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dboТОВАРЫBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
       // private DB_StorageDataSet dB_StorageDataSet;
        private System.Windows.Forms.BindingSource dboТОВАРЫBindingSource;
      //  private DB_StorageDataSetTableAdapters.dbo_ТОВАРЫTableAdapter dbo_ТОВАРЫTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работасданнымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стоимостьИнвентаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиСУчёткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

