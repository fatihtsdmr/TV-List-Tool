namespace WindowsFormsApp1
{
    partial class home_Page
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
            this.save_button = new System.Windows.Forms.Button();
            this.tv_ListDataSet1 = new WindowsFormsApp1.Tv_ListDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelofTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTvListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tv_ListDataSet2 = new WindowsFormsApp1.Tv_ListDataSet2();
            this.tv_ListDataSet11 = new WindowsFormsApp1.Tv_ListDataSet1();
            this.tvListDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Tv_ListTableAdapter = new WindowsFormsApp1.Tv_ListDataSet2TableAdapters.Tbl_Tv_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTvListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvListDataSet11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(398, 234);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(152, 64);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "button1";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // tv_ListDataSet1
            // 
            this.tv_ListDataSet1.DataSetName = "Tv_ListDataSet";
            this.tv_ListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.numberofTVDataGridViewTextBoxColumn,
            this.modelofTVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTvListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberofTVDataGridViewTextBoxColumn
            // 
            this.numberofTVDataGridViewTextBoxColumn.DataPropertyName = "numberofTV";
            this.numberofTVDataGridViewTextBoxColumn.HeaderText = "numberofTV";
            this.numberofTVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberofTVDataGridViewTextBoxColumn.Name = "numberofTVDataGridViewTextBoxColumn";
            this.numberofTVDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelofTVDataGridViewTextBoxColumn
            // 
            this.modelofTVDataGridViewTextBoxColumn.DataPropertyName = "modelofTV";
            this.modelofTVDataGridViewTextBoxColumn.HeaderText = "modelofTV";
            this.modelofTVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelofTVDataGridViewTextBoxColumn.Name = "modelofTVDataGridViewTextBoxColumn";
            this.modelofTVDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblTvListBindingSource
            // 
            this.tblTvListBindingSource.DataMember = "Tbl_Tv_List";
            this.tblTvListBindingSource.DataSource = this.tv_ListDataSet2;
            // 
            // tv_ListDataSet2
            // 
            this.tv_ListDataSet2.DataSetName = "Tv_ListDataSet2";
            this.tv_ListDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tv_ListDataSet11
            // 
            this.tv_ListDataSet11.DataSetName = "Tv_ListDataSet1";
            this.tv_ListDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tvListDataSet11BindingSource
            // 
            this.tvListDataSet11BindingSource.DataSource = this.tv_ListDataSet11;
            this.tvListDataSet11BindingSource.Position = 0;
            // 
            // tbl_Tv_ListTableAdapter
            // 
            this.tbl_Tv_ListTableAdapter.ClearBeforeFill = true;
            // 
            // home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 705);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save_button);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home_Page";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTvListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_ListDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvListDataSet11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private Tv_ListDataSet tv_ListDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tvListDataSet11BindingSource;
        private Tv_ListDataSet1 tv_ListDataSet11;
        private Tv_ListDataSet2 tv_ListDataSet2;
        private System.Windows.Forms.BindingSource tblTvListBindingSource;
        private Tv_ListDataSet2TableAdapters.Tbl_Tv_ListTableAdapter tbl_Tv_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelofTVDataGridViewTextBoxColumn;
    }
}

