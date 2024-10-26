namespace Case409_csv
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadCsv;
        private System.Windows.Forms.Button buttonLoadKA11;
        private System.Windows.Forms.Button buttonLoadKA12;
        private System.Windows.Forms.Button buttonLoadKA14;
        private System.Windows.Forms.Button buttonSaveCsv;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonLoadCsv = new Button();
            buttonLoadKA11 = new Button();
            buttonLoadKA12 = new Button();
            buttonLoadKA14 = new Button();
            buttonSaveCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 58);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(905, 448);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // buttonLoadCsv
            // 
            buttonLoadCsv.BackColor = Color.FromArgb(255, 192, 255);
            buttonLoadCsv.Location = new Point(14, 14);
            buttonLoadCsv.Margin = new Padding(4, 3, 4, 3);
            buttonLoadCsv.Name = "buttonLoadCsv";
            buttonLoadCsv.Size = new Size(117, 35);
            buttonLoadCsv.TabIndex = 1;
            buttonLoadCsv.Text = "Load CSV";
            buttonLoadCsv.UseVisualStyleBackColor = false;
            buttonLoadCsv.Click += buttonLoadCsv_Click;
            // 
            // buttonLoadKA11
            // 
            buttonLoadKA11.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA11.Location = new Point(14, 54);
            buttonLoadKA11.Margin = new Padding(4, 3, 4, 3);
            buttonLoadKA11.Name = "buttonLoadKA11";
            buttonLoadKA11.Size = new Size(88, 35);
            buttonLoadKA11.TabIndex = 2;
            buttonLoadKA11.Text = "KA11LICH";
            buttonLoadKA11.UseVisualStyleBackColor = false;
            buttonLoadKA11.Click += buttonLoadKA11_Click;
            // 
            // buttonLoadKA12
            // 
            buttonLoadKA12.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA12.Location = new Point(108, 54);
            buttonLoadKA12.Margin = new Padding(4, 3, 4, 3);
            buttonLoadKA12.Name = "buttonLoadKA12";
            buttonLoadKA12.Size = new Size(88, 35);
            buttonLoadKA12.TabIndex = 3;
            buttonLoadKA12.Text = "KA12LICF";
            buttonLoadKA12.UseVisualStyleBackColor = false;
            buttonLoadKA12.Click += buttonLoadKA12_Click;
            // 
            // buttonLoadKA14
            // 
            buttonLoadKA14.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA14.Location = new Point(203, 54);
            buttonLoadKA14.Margin = new Padding(4, 3, 4, 3);
            buttonLoadKA14.Name = "buttonLoadKA14";
            buttonLoadKA14.Size = new Size(88, 35);
            buttonLoadKA14.TabIndex = 4;
            buttonLoadKA14.Text = "KA14HFUY";
            buttonLoadKA14.UseVisualStyleBackColor = false;
            buttonLoadKA14.Click += buttonLoadKA14_Click;
            // 
            // buttonSaveCsv
            // 
            buttonSaveCsv.BackColor = Color.FromArgb(255, 192, 255);
            buttonSaveCsv.Location = new Point(802, 14);
            buttonSaveCsv.Margin = new Padding(4, 3, 4, 3);
            buttonSaveCsv.Name = "buttonSaveCsv";
            buttonSaveCsv.Size = new Size(117, 35);
            buttonSaveCsv.TabIndex = 5;
            buttonSaveCsv.Text = "Save CSV";
            buttonSaveCsv.UseVisualStyleBackColor = false;
            buttonSaveCsv.Click += buttonSaveCsv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonLoadCsv);
            Controls.Add(buttonSaveCsv);
            Controls.Add(buttonLoadKA14);
            Controls.Add(buttonLoadKA12);
            Controls.Add(buttonLoadKA11);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "CSV and Database Loader";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
