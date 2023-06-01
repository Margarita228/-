namespace СалонКрасоты
{
    partial class ManagerForm
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
            this.парикмахерскаяDataSet = new СалонКрасоты.ПарикмахерскаяDataSet();
            this.стрижкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стрижкиTableAdapter = new СалонКрасоты.ПарикмахерскаяDataSetTableAdapters.СтрижкиTableAdapter();
            this.tableAdapterManager = new СалонКрасоты.ПарикмахерскаяDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.парикмахерскаяDataSet1 = new СалонКрасоты.ПарикмахерскаяDataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.парикмахерскаяDataSet9 = new СалонКрасоты.ПарикмахерскаяDataSet9();
            this.работаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работаTableAdapter = new СалонКрасоты.ПарикмахерскаяDataSet9TableAdapters.РаботаTableAdapter();
            this.tableAdapterManager1 = new СалонКрасоты.ПарикмахерскаяDataSet9TableAdapters.TableAdapterManager();
            this.работаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.работаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.парикмахерскаяDataSet11 = new СалонКрасоты.ПарикмахерскаяDataSet11();
            this.работаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.работаTableAdapter1 = new СалонКрасоты.ПарикмахерскаяDataSet11TableAdapters.РаботаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стрижкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // парикмахерскаяDataSet
            // 
            this.парикмахерскаяDataSet.DataSetName = "ПарикмахерскаяDataSet";
            this.парикмахерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стрижкиBindingSource
            // 
            this.стрижкиBindingSource.DataMember = "Стрижки";
            this.стрижкиBindingSource.DataSource = this.парикмахерскаяDataSet;
            // 
            // стрижкиTableAdapter
            // 
            this.стрижкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = СалонКрасоты.ПарикмахерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СтрижкиTableAdapter = this.стрижкиTableAdapter;
            this.tableAdapterManager.ФилиалыTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать в меню менеджера.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(597, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотреть статистику по филиалам";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // парикмахерскаяDataSet1
            // 
            this.парикмахерскаяDataSet1.DataSetName = "ПарикмахерскаяDataSet";
            this.парикмахерскаяDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(597, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 182);
            this.dataGridView1.TabIndex = 4;
            // 
            // парикмахерскаяDataSet9
            // 
            this.парикмахерскаяDataSet9.DataSetName = "ПарикмахерскаяDataSet9";
            this.парикмахерскаяDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работаBindingSource
            // 
            this.работаBindingSource.DataMember = "Работа";
            this.работаBindingSource.DataSource = this.парикмахерскаяDataSet9;
            // 
            // работаTableAdapter
            // 
            this.работаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = СалонКрасоты.ПарикмахерскаяDataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.РаботаTableAdapter = this.работаTableAdapter;
            // 
            // работаDataGridView
            // 
            this.работаDataGridView.AutoGenerateColumns = false;
            this.работаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.работаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.работаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.работаDataGridView.DataSource = this.работаBindingSource2;
            this.работаDataGridView.Location = new System.Drawing.Point(18, 76);
            this.работаDataGridView.Name = "работаDataGridView";
            this.работаDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.работаDataGridView.RowTemplate.Height = 24;
            this.работаDataGridView.Size = new System.Drawing.Size(569, 348);
            this.работаDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код работы";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код работы";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код клиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код филиала";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код филиала";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn6.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(607, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Код филиала: 1 - ул. Марата, д. 8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(627, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "2 - пр-кт Энгельса, д. 129 к4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(627, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "3 - ул. Есенина, д. 8";
            // 
            // работаBindingSource1
            // 
            this.работаBindingSource1.DataMember = "Работа";
            this.работаBindingSource1.DataSource = this.парикмахерскаяDataSet9;
            // 
            // парикмахерскаяDataSet11
            // 
            this.парикмахерскаяDataSet11.DataSetName = "ПарикмахерскаяDataSet11";
            this.парикмахерскаяDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работаBindingSource2
            // 
            this.работаBindingSource2.DataMember = "Работа";
            this.работаBindingSource2.DataSource = this.парикмахерскаяDataSet11;
            // 
            // работаTableAdapter1
            // 
            this.работаTableAdapter1.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(915, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.работаDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стрижкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ПарикмахерскаяDataSet парикмахерскаяDataSet;
        private System.Windows.Forms.BindingSource стрижкиBindingSource;
        private ПарикмахерскаяDataSetTableAdapters.СтрижкиTableAdapter стрижкиTableAdapter;
        private ПарикмахерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ПарикмахерскаяDataSet парикмахерскаяDataSet1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ПарикмахерскаяDataSet9 парикмахерскаяDataSet9;
        private System.Windows.Forms.BindingSource работаBindingSource;
        private ПарикмахерскаяDataSet9TableAdapters.РаботаTableAdapter работаTableAdapter;
        private ПарикмахерскаяDataSet9TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView работаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource работаBindingSource1;
        private ПарикмахерскаяDataSet11 парикмахерскаяDataSet11;
        private System.Windows.Forms.BindingSource работаBindingSource2;
        private ПарикмахерскаяDataSet11TableAdapters.РаботаTableAdapter работаTableAdapter1;
    }
}