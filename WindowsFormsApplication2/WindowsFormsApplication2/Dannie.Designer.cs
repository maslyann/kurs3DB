namespace WindowsFormsApplication2
{
    partial class Dannie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dannie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.актаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПодписанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.актBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new WindowsFormsApplication2.KursDataSet();
            this.актTableAdapter = new WindowsFormsApplication2.KursDataSetTableAdapters.АктTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.актаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инвентарныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОбъектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВводаВЭксплDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.акт2ДанныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2ДанныеTableAdapter = new WindowsFormsApplication2.KursDataSetTableAdapters._2ДанныеTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.инвентарныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.первоначальнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.восстановительнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическийИзносРубDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическийИзносDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остаточнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вТЧКредитDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данные2СтоимостBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2СтоимостTableAdapter = new WindowsFormsApplication2.KursDataSetTableAdapters._2СтоимостTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.актBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акт2ДанныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные2СтоимостBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.актаDataGridViewTextBoxColumn,
            this.наименованиеПредприятияDataGridViewTextBoxColumn,
            this.месяцDataGridViewTextBoxColumn,
            this.датаПодписанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.актBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 10);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(445, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // актаDataGridViewTextBoxColumn
            // 
            this.актаDataGridViewTextBoxColumn.DataPropertyName = "№ акта";
            this.актаDataGridViewTextBoxColumn.HeaderText = "№ акта";
            this.актаDataGridViewTextBoxColumn.Name = "актаDataGridViewTextBoxColumn";
            // 
            // наименованиеПредприятияDataGridViewTextBoxColumn
            // 
            this.наименованиеПредприятияDataGridViewTextBoxColumn.DataPropertyName = "наименование предприятия";
            this.наименованиеПредприятияDataGridViewTextBoxColumn.HeaderText = "наименование предприятия";
            this.наименованиеПредприятияDataGridViewTextBoxColumn.Name = "наименованиеПредприятияDataGridViewTextBoxColumn";
            // 
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "месяц";
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            // 
            // датаПодписанияDataGridViewTextBoxColumn
            // 
            this.датаПодписанияDataGridViewTextBoxColumn.DataPropertyName = "дата подписания";
            this.датаПодписанияDataGridViewTextBoxColumn.HeaderText = "дата подписания";
            this.датаПодписанияDataGridViewTextBoxColumn.Name = "датаПодписанияDataGridViewTextBoxColumn";
            // 
            // актBindingSource
            // 
            this.актBindingSource.DataMember = "Акт";
            this.актBindingSource.DataSource = this.kursDataSetBindingSource;
            // 
            // kursDataSetBindingSource
            // 
            this.kursDataSetBindingSource.DataSource = this.kursDataSet;
            this.kursDataSetBindingSource.Position = 0;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // актTableAdapter
            // 
            this.актTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.актаDataGridViewTextBoxColumn1,
            this.инвентарныйНомерDataGridViewTextBoxColumn,
            this.наименованиеОбъектаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.годВводаВЭксплDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.акт2ДанныеBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(20, 162);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 110);
            this.dataGridView2.TabIndex = 1;
            // 
            // актаDataGridViewTextBoxColumn1
            // 
            this.актаDataGridViewTextBoxColumn1.DataPropertyName = "№ акта";
            this.актаDataGridViewTextBoxColumn1.HeaderText = "№ акта";
            this.актаDataGridViewTextBoxColumn1.Name = "актаDataGridViewTextBoxColumn1";
            // 
            // инвентарныйНомерDataGridViewTextBoxColumn
            // 
            this.инвентарныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn.HeaderText = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn.Name = "инвентарныйНомерDataGridViewTextBoxColumn";
            // 
            // наименованиеОбъектаDataGridViewTextBoxColumn
            // 
            this.наименованиеОбъектаDataGridViewTextBoxColumn.DataPropertyName = "Наименование объекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.HeaderText = "Наименование объекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.Name = "наименованиеОбъектаDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // годВводаВЭксплDataGridViewTextBoxColumn
            // 
            this.годВводаВЭксплDataGridViewTextBoxColumn.DataPropertyName = "Год ввода в экспл";
            this.годВводаВЭксплDataGridViewTextBoxColumn.HeaderText = "Год ввода в экспл";
            this.годВводаВЭксплDataGridViewTextBoxColumn.Name = "годВводаВЭксплDataGridViewTextBoxColumn";
            // 
            // акт2ДанныеBindingSource
            // 
            this.акт2ДанныеBindingSource.DataMember = "Акт2Данные";
            this.акт2ДанныеBindingSource.DataSource = this.актBindingSource;
            // 
            // _2ДанныеTableAdapter
            // 
            this._2ДанныеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.инвентарныйНомерDataGridViewTextBoxColumn1,
            this.первоначальнаяСтоимостьDataGridViewTextBoxColumn,
            this.восстановительнаяСтоимостьDataGridViewTextBoxColumn,
            this.фактическийИзносРубDataGridViewTextBoxColumn,
            this.фактическийИзносDataGridViewTextBoxColumn,
            this.остаточнаяСтоимостьDataGridViewTextBoxColumn,
            this.вТЧКредитDataGridViewTextBoxColumn,
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.данные2СтоимостBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(20, 302);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(836, 166);
            this.dataGridView3.TabIndex = 2;
            // 
            // инвентарныйНомерDataGridViewTextBoxColumn1
            // 
            this.инвентарныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn1.HeaderText = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn1.Name = "инвентарныйНомерDataGridViewTextBoxColumn1";
            // 
            // первоначальнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.первоначальнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Первоначальная стоимость";
            this.первоначальнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Первоначальная стоимость";
            this.первоначальнаяСтоимостьDataGridViewTextBoxColumn.Name = "первоначальнаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // восстановительнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.восстановительнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Восстановительная стоимость";
            this.восстановительнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Восстановительная стоимость";
            this.восстановительнаяСтоимостьDataGridViewTextBoxColumn.Name = "восстановительнаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // фактическийИзносРубDataGridViewTextBoxColumn
            // 
            this.фактическийИзносРубDataGridViewTextBoxColumn.DataPropertyName = "Фактический износ, руб";
            this.фактическийИзносРубDataGridViewTextBoxColumn.HeaderText = "Фактический износ, руб";
            this.фактическийИзносРубDataGridViewTextBoxColumn.Name = "фактическийИзносРубDataGridViewTextBoxColumn";
            // 
            // фактическийИзносDataGridViewTextBoxColumn
            // 
            this.фактическийИзносDataGridViewTextBoxColumn.DataPropertyName = "Фактический износ, %";
            this.фактическийИзносDataGridViewTextBoxColumn.HeaderText = "Фактический износ, %";
            this.фактическийИзносDataGridViewTextBoxColumn.Name = "фактическийИзносDataGridViewTextBoxColumn";
            // 
            // остаточнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.остаточнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Остаточная стоимость";
            this.остаточнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Остаточная стоимость";
            this.остаточнаяСтоимостьDataGridViewTextBoxColumn.Name = "остаточнаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // вТЧКредитDataGridViewTextBoxColumn
            // 
            this.вТЧКредитDataGridViewTextBoxColumn.DataPropertyName = "в т ч кредит";
            this.вТЧКредитDataGridViewTextBoxColumn.HeaderText = "в т ч кредит";
            this.вТЧКредитDataGridViewTextBoxColumn.Name = "вТЧКредитDataGridViewTextBoxColumn";
            // 
            // оценочнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Оценочная стоимость";
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Оценочная стоимость";
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.Name = "оценочнаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // данные2СтоимостBindingSource
            // 
            this.данные2СтоимостBindingSource.DataMember = "2Данные2Стоимост";
            this.данные2СтоимостBindingSource.DataSource = this.акт2ДанныеBindingSource;
            // 
            // _2СтоимостTableAdapter
            // 
            this._2СтоимостTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 455);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(868, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dannie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(868, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dannie";
            this.Text = "Dannie";
            this.Load += new System.EventHandler(this.Dannie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.актBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акт2ДанныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные2СтоимостBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kursDataSetBindingSource;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource актBindingSource;
        private KursDataSetTableAdapters.АктTableAdapter актTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn актаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПодписанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource акт2ДанныеBindingSource;
        private KursDataSetTableAdapters._2ДанныеTableAdapter _2ДанныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn актаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn инвентарныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОбъектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВводаВЭксплDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource данные2СтоимостBindingSource;
        private KursDataSetTableAdapters._2СтоимостTableAdapter _2СтоимостTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn инвентарныйНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn первоначальнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn восстановительнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическийИзносРубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическийИзносDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остаточнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вТЧКредитDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценочнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button2;

    }
}