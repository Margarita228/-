namespace СалонКрасоты
{
    partial class AccountantForm
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
            this.парикмахерскаяDataSet1 = new СалонКрасоты.ПарикмахерскаяDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.филиалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.филиалыTableAdapter = new СалонКрасоты.ПарикмахерскаяDataSetTableAdapters.ФилиалыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.филиалыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // парикмахерскаяDataSet1
            // 
            this.парикмахерскаяDataSet1.DataSetName = "ПарикмахерскаяDataSet";
            this.парикмахерскаяDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Экспорт в PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(776, 253);
            this.dgv.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Поиск по дате";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // филиалыBindingSource
            // 
            this.филиалыBindingSource.DataMember = "Филиалы";
            this.филиалыBindingSource.DataSource = this.парикмахерскаяDataSet1;
            // 
            // филиалыTableAdapter
            // 
            this.филиалыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспорт в CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button2);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            this.Load += new System.EventHandler(this.AccountantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскаяDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.филиалыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ПарикмахерскаяDataSet парикмахерскаяDataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource филиалыBindingSource;
        private ПарикмахерскаяDataSetTableAdapters.ФилиалыTableAdapter филиалыTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}