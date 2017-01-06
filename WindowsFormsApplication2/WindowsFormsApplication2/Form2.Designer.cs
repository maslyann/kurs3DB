namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.арендаторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        //    this.dADADataSet = new WindowsFormsApplication2.DADADataSet();
          //  this.арендаторTableAdapter = new WindowsFormsApplication2.DADADataSetTableAdapters.АрендаторTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.dADADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // арендаторBindingSource
            // 
            this.арендаторBindingSource.DataMember = "Арендатор";
            this.арендаторBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
       //     this.bindingSource1.DataSource = this.dADADataSet;
            this.bindingSource1.Position = 0;
            // 
            // dADADataSet
            // 
       //     this.dADADataSet.DataSetName = "DADADataSet";
        //    this.dADADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендаторTableAdapter
            // 
      //      this.арендаторTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 346);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
         //   ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.dADADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
      //  private DADADataSet dADADataSet;
        private System.Windows.Forms.BindingSource арендаторBindingSource;
        //private DADADataSetTableAdapters.АрендаторTableAdapter арендаторTableAdapter;
    }
}